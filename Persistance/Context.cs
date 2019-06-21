using Common;
using System.Data.Entity;

namespace Persistance
{
    public class Context : DbContext
    {
        //Zrezygnowałem z korzystania z connection stringa z App.config, ponieważ były problemy
        public Context() : base("Server=145.239.87.214;Database=PomodoroTests;User Id=sa;Password='ds9-z0AOcx0a-;'")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LogHistory> LoggingHistory { get; set; }
        public DbSet<Stats> UserStats { get; set; }
    }
}
