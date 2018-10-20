using Microsoft.EntityFrameworkCore;

namespace HealthcarePortalBackend.Adapters.Storage
{
    public class RegisteredUsersContext : DbContext
    {
        public RegisteredUsersContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<RegisteredUserRecord> RegisteredUsers { get; set; }
    }
}