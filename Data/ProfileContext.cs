using Data.Models;
using Data.Utilities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ProfileContext : DbContext, IProfileContext
    {
        public DbSet<Profile> Profiles { get; set; }

        public ProfileContext() 
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConnectionStringUtility.BuildConnectionString();
            optionsBuilder.UseSqlite(connectionString);
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
