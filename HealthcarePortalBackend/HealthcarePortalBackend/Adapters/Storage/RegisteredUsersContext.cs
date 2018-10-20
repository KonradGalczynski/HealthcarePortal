using Microsoft.EntityFrameworkCore;

namespace HealthcarePortalBackend.Adapters.Storage
{
    public class RegisteredUsersContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=RegisteredUsersContext;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=SSPI");
        }

        public DbSet<RegisteredUserRecord> RegisteredUsers { get; set; }
    }
}