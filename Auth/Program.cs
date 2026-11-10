using Auth.Forms;
using Auth.Services;
namespace Auth
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
            if (!DatabaseHelper.TestConnection(out string errorMsg))
            {
                MessageBox.Show($"Koneksi database gagal:\n{errorMsg}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}