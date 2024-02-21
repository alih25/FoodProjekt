using FoodProjekt.api.Data;
using Microsoft.EntityFrameworkCore;


namespace FoodProjekt.api.Extensions
{
    public static class StartupDbContextExtension
    {
        public static IServiceCollection AddDataContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString(DataContext.ConnectionStringName);
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
            
            return services;
        }
        
    }
}
