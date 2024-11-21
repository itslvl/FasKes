using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using FasKes.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using FasKes.Domain.Repository.R;
using FasKes.Domain.Entity.R;
using FasKes.Infrastructure.Repository;

namespace FasKes.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            // var a = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("SqliteConnection")));
            //     // ??
            //     //     throw new InvalidOperationException("Connection string 'DefaultConnection' is null"))
            // );

            services.AddTransient<IRPendidikan1Repo, RPendidikan1Repo>();
            return services;
        }
    }
}