using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Switch.Infra.Data.Context;

namespace Switch.API
{
    public IConfiguration Configuration { get; }
    public class Startup
    {
        IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("config.Json");
            Configuration = builder.Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
           var conn = Configuration.GetConnectionString("SwitchDB");
            services.AddDbContext<SwitchContext>(option => option.UseLazyloandingProxies ()
                                     .UseMySql(conn, mbox => m.MigrationsAssembly("Switch.Infra.Data")));
            services.AddMvcCore();

        }

      
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
