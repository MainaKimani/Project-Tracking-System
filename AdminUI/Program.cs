namespace AdminUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var main = new LoginForm();
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();
            Application.Run();
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((System.Windows.Forms.Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }


    }
}