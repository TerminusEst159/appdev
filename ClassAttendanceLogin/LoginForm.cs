namespace ClassAttendanceLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            btnLogin.Enabled = false;

            try
            {
                var session = await SupabaseService.Client.Auth.SignIn(
                    txtEmail.Text.Trim(), txtPassword.Text);

                var profile = await SupabaseService.Client
                    .From<Profile>()
                    .Where(p => p.Id == session.User.Id)
                    .Single();

                if (profile.Role == "teacher")
                {
                    Hide();
                    var form = new AttendanceForm(profile);
                    form.FormClosed += (s, args) => Close();
                    form.Show();
                }
                else
                {
                    lblMessage.Text = "Student view is coming soon.";
                }
            }
            catch (Exception)
            {
                lblMessage.Text = "Login failed. Check your email and password.";
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}