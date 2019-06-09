using PomodoroTimer.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    class MyContext : DbContext
    {
        public MyContext() : base("DBConnectionString")
        {
            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Stats> Statistics { get; set; }
    }
}
