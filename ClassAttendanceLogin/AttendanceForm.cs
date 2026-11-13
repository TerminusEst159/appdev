using Supabase.Postgrest;
using static Supabase.Postgrest.Constants;

namespace ClassAttendanceLogin
{
    public partial class AttendanceForm : Form
    {
        private readonly Profile _teacher;

        public AttendanceForm(Profile teacher)
        {
            InitializeComponent();
            _teacher = teacher;

            Load -= AttendanceForm_Load;
            Load += AttendanceForm_Load;
            btnLoad.Click -= btnLoad_Click;
            btnLoad.Click += btnLoad_Click;
            btnSave.Click -= btnSave_Click;
            btnSave.Click += btnSave_Click;
            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private async void AttendanceForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_teacher.FullName}";
            SetupGrid();

            try
            {
                var result = await SupabaseService.Client.From<ClassRoom>().Get();
                cboClass.DataSource = result.Models;
            }
            catch (Exception ex)
            {
                ShowStatus("Couldn't load classes: " + ex.Message, true);
            }
        }

        private void SetupGrid()
        {
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "colId", Visible = false });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "colName", HeaderText = "Student", ReadOnly = true });

            var status = new DataGridViewComboBoxColumn
            { Name = "colStatus", HeaderText = "Status", FlatStyle = FlatStyle.Flat };
            status.Items.AddRange("Present", "Absent", "Late");
            dgvStudents.Columns.Add(status);
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            if (cboClass.SelectedItem is not ClassRoom selectedClass) return;

            lblStatus.Text = "";
            dgvStudents.Rows.Clear();
            var date = dtpDate.Value.Date;

            try
            {
                var enrolled = await SupabaseService.Client.From<Enrollment>()
                    .Filter("class_id", Operator.Equals, selectedClass.Id)
                    .Get();
                var studentIds = enrolled.Models.Select(x => x.StudentId).ToList();
                if (studentIds.Count == 0)
                {
                    ShowStatus("No students in this class.", true);
                    return;
                }

                var students = await SupabaseService.Client.From<Profile>()
                    .Filter("id", Operator.In, studentIds)
                    .Get();

                var saved = await SupabaseService.Client.From<AttendanceRecord>()
                    .Filter("class_id", Operator.Equals, selectedClass.Id)
                    .Filter("date", Operator.Equals, date.ToString("yyyy-MM-dd"))
                    .Get();

                foreach (var s in students.Models.OrderBy(s => s.FullName))
                {
                    var existing = saved.Models.FirstOrDefault(r => r.StudentId == s.Id);
                    dgvStudents.Rows.Add(s.Id, s.FullName, existing?.Status ?? "Present");
                }
            }
            catch (Exception ex)
            {
                ShowStatus("Couldn't load students: " + ex.Message, true);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (cboClass.SelectedItem is not ClassRoom selectedClass || dgvStudents.Rows.Count == 0)
            {
                ShowStatus("Load a class first.", true);
                return;
            }

            var records = new List<AttendanceRecord>();
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                records.Add(new AttendanceRecord
                {
                    ClassId = selectedClass.Id,
                    StudentId = row.Cells["colId"].Value.ToString(),
                    Date = dtpDate.Value.Date,
                    Status = row.Cells["colStatus"].Value?.ToString() ?? "Present"
                });
            }

            btnSave.Enabled = false;
            try
            {
                await SupabaseService.Client.From<AttendanceRecord>()
                    .Upsert(records, new QueryOptions { OnConflict = "class_id,student_id,date" });
                ShowStatus("Attendance saved.", false);
            }
            catch (Exception ex)
            {
                ShowStatus("Couldn't save: " + ex.Message, true);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            await SupabaseService.Client.Auth.SignOut();
            Close();
        }

        private void ShowStatus(string text, bool isError)
        {
            lblStatus.ForeColor = isError ? Color.Red : Color.Green;
            lblStatus.Text = text;
        }
    }
}