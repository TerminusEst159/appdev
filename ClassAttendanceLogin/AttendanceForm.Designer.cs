namespace ClassAttendanceLogin
{
    partial class AttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnLogout = new Button();
            lblClass = new Label();
            cboClass = new ComboBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            btnLoad = new Button();
            dgvStudents = new DataGridView();
            btnSave = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 12F);
            lblWelcome.Location = new Point(26, 23);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(79, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Greetings";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(348, 9);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 37);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Microsoft Sans Serif", 12F);
            lblClass.Location = new Point(26, 54);
            lblClass.Margin = new Padding(4, 0, 4, 0);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(48, 20);
            lblClass.TabIndex = 2;
            lblClass.Text = "Class";
            // 
            // cboClass
            // 
            cboClass.FormattingEnabled = true;
            cboClass.Location = new Point(12, 81);
            cboClass.Margin = new Padding(4, 3, 4, 3);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(146, 23);
            cboClass.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 12F);
            lblDate.Location = new Point(210, 54);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(215, 82);
            dtpDate.Margin = new Padding(4, 3, 4, 3);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(233, 23);
            dtpDate.TabIndex = 5;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 112);
            btnLoad.Margin = new Padding(4, 3, 4, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(106, 40);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load Students";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 159);
            dgvStudents.Margin = new Padding(4, 3, 4, 3);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(436, 218);
            dgvStudents.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(315, 398);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 39);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Attendance";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(348, 125);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status";
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 464);
            Controls.Add(lblStatus);
            Controls.Add(btnSave);
            Controls.Add(dgvStudents);
            Controls.Add(btnLoad);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(cboClass);
            Controls.Add(lblClass);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AttendanceForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnSave;
        private Label lblStatus;
    }
}