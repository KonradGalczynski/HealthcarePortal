using HealthcarePortalBackend.Adapters.Storage;
using HealthcarePortalBackend.Ports.Storage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace HealthcarePortalBackend
{
    public abstract class StartupBase
    {
        protected StartupBase(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //services.AddDbContext<RegisteredUsersContext>(options => options.UseInMemoryDatabase());
            ConfigureStorage(services);

            services.AddScoped<IRegisteredUsersStorage, RegisteredUsersStorage>();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "HealthcarePortal API", Version = "v1" });
            });
        }

        protected abstract void ConfigureStorage(IServiceCollection services);

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "HealthcarePortal API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}