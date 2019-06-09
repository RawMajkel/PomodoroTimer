using PomodoroTimer.Classes;
using System.Data.Entity;

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
