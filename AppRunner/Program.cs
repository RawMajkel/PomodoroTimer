using Persistance;
using System;
using System.Windows.Forms;
using Services;

namespace AppRunner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var _ctx = new Context())
            {
                //_ctx.Database.CreateIfNotExists();

                if (UserService.CheckLastLoggedUser().IsValidated)
                {
                    Application.Run(new WorkForm());
                }
                else
                {
                    Application.Run(new WelcomeForm());
                }
            }
        }
    }
}