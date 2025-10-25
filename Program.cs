using Corvus.Data;
using Microsoft.EntityFrameworkCore;

namespace Corvus
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
            Application.Run(new Form1());

            try
            {
                using (var db = new AppDbContext())
                {
                    db.Database.Migrate();
                }

                // show login form
                using var login = new Forms.LoginForm();
                login.ShowDialog();

                /* if (login.ShowDialog() == DialogResult.OK)
                {
                Application.Run(new Forms.HomeForm(Login.LoggedInUser));

                } */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Failed!\nPlease Check Your Nework" +
                "\nCode:" + ex.Message,
                "Database Connection ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}