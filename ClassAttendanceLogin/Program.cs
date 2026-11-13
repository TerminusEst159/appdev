using ClassAttendanceLogin;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        SupabaseService.InitAsync().GetAwaiter().GetResult();
        Application.Run(new LoginForm());
    }
}