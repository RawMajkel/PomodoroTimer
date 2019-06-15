using Common;
using System.Data.Entity;

namespace Persistance
{
    public class Context : DbContext
    {
        public Context() : base("DBConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Stats> Statistics { get; set; }
    }
}
