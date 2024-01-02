using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
namespace Nop.Web.Infrastructure
{
    public class CorsPolicyStartup : INopStartup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(feature =>
                feature.AddPolicy(
                    "Frontend",
                    apiPolicy => apiPolicy
                        .WithOrigins("http://localhost:81")
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .SetIsOriginAllowed(host => true)
                ));
        }

        public void Configure(IApplicationBuilder application)
        {
            application.UseCors("Frontend");
        }

        public int Order => 500; //CorsPolicy should be after MVC

    }
}
