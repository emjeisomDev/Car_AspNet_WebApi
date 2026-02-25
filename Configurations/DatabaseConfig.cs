using CarTest.Context;
using Microsoft.EntityFrameworkCore;

namespace CarTest.Configurations
{
    public static class DatabaseConfig
    {
        public static IServiceCollection AddDatabaseConfiguration
            (this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["MSSQLServerSQLConnection:MSSQLServerSQLConnectionString"];
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("Connection string 'MSSQLServerSQLConnectionString' not found.");
            }

            services.AddDbContext<VehicleContext>(options =>
                options.UseSqlServer(connectionString));
            return services;
        }
    }
}
