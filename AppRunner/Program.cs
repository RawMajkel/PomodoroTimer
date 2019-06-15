//using Common;
using Persistance;
using System;
using System.Windows.Forms;

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
            using (var ctx = new Context())
            {
                //ctx.Database.Delete();
                ctx.Database.CreateIfNotExists();

                //Dodaj dane testowe

                //ctx.Users.Add(new User("mdrozdzik", "m.drozdzik97@gmail.com", "admin"));
                //ctx.SaveChanges();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}