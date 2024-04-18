//using Account;
//using Microsoft.VisualBasic.ApplicationServices;

using AccountWF.Models;

namespace AccountWF
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
            User admin = new User
            {
                Name = "admin",
                Email = "admin@gmail.com",
                Password = "admin"
            };
            DB.Database.users.Add(admin);
            Application.Run(new Login());
            //Account account = new Account(admin);
            //Application.Run(new FrmAccount(account));
        }
    }
}