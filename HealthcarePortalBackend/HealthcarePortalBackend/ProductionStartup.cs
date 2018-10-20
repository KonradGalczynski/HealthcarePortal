using HealthcarePortalBackend.Adapters.Storage;
using HealthcarePortalBackend.Ports.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HealthcarePortalBackend
{
    public class ProductionStartup : StartupBase
    {
        public ProductionStartup(IConfiguration configuration) 
            : base(configuration)
        {

        }

        protected override void ConfigureStorage(IServiceCollection services)
        {
            services.AddDbContext<RegisteredUsersContext>(options => options.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=RegisteredUsersContext;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=SSPI"));
        }
    }
}