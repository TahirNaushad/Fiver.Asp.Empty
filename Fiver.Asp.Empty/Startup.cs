using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Fiver.Asp.Empty
{
    public class Startup
    {
        public Startup(
            IHostingEnvironment env,
            ILoggerFactory loggerFactory,
            IConfiguration config)
        {
             
        }

        public void ConfigureServices(
            IServiceCollection services)
        {
            // setup dependency injection in service container
        }

        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env)
        {
            // setup request pipeline using middleware
        }
    }
}
