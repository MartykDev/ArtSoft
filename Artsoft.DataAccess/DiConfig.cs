using Artsoft.DataAccess.Repositories;
using Artsoft.DataAccess.Repositories.Interfaces;

using Microsoft.Extensions.DependencyInjection;

namespace Artsoft.DataAccess
{
    public static class DiConfig
    {
        public static IServiceCollection ConfigureDataAccessRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IProgrammingLanguageRepository, ProgrammingLanguageRepository>();

            return services;
        }
    }
}