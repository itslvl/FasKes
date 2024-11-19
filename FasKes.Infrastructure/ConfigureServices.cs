using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace FasKes.Infrastructure
{
    public static class ConfigureServices
    {
     public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration  configuration)
        {
            // services.AddAutoMapper(Assembly.GetExecutingAssembly());
            // services.AddMediatR( c => {
            //     c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            // });
            return services;
        }   
    }
}