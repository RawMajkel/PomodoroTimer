using Common;
using Persistance;
using System;
using System.Linq;
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
                //_ctx.Database.Delete();
                _ctx.Database.CreateIfNotExists();

                //_ctx.Users.Add(new User("mdrozdzik", "m.drozdzik97@gmail.com", "admin"));
                //_ctx.SaveChanges();

                //sprawdz czy istnieje ostatnio zalogowany user
                if (_ctx.__LoggingHistory.Select(x => x.UserId).Any())
                {
                    var lastLoggedUser = _ctx.__LoggingHistory.Select(x => new LogHelper { UserId = x.UserId, LogDate = x.LogDate }).OrderByDescending(x => x.LogDate).First();

                    //jeśli tak, sprwadź czy istnieje
                    if (_ctx.Users.Any(x => x.UserId == lastLoggedUser.UserId))
                    {
                        //zaloguj
                        UserService.Login(_ctx.Users.Where(x => x.UserId == lastLoggedUser.UserId).First());
                        Application.Run(new WorkForm());
                        return;
                    }
                }
                else
                {
                    Application.Run(new WelcomeForm());
                }

            }
        }
    }
}