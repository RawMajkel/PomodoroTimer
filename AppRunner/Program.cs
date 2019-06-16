using Persistance;
using System;
using System.Windows.Forms;
using Services;
using Common.Consts;
using Common;

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
                //_ctx.Database.Delete();
                _ctx.Database.CreateIfNotExists();

                var user = new User("asd", "asd", "asd@asd.com");

                _ctx.Users.Add(user);
                _ctx.UserStats.Add(new Stats(user, Consts.PomodoroWork));

                _ctx.SaveChanges();

                var response = UserService.CheckLastLoggedUser();

                if (response.IsValidated)
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