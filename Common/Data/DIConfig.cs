using Common.Data.Interfaces;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Common.Data
{
    public static class DiConfig
    {
        public static IServiceCollection AddDatabaseClient(this IServiceCollection services, string connectionStringName)
        {
            services.AddTransient<IDatabaseClient>(serviceProvider => {
                var configuration = serviceProvider.GetRequiredService<IConfiguration>();
                var connectionString = configuration.GetConnectionString(connectionStringName);

                return ActivatorUtilities.CreateInstance<DatabaseClient>(serviceProvider, connectionString);
            });
            return services;
        }
    }
}