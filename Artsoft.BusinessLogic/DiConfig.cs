using Artsoft.DataAccess;
using Artsoft.BusinessLogic.Services;
using Artsoft.BusinessLogic.Services.Interfaces;

using Microsoft.Extensions.DependencyInjection;

namespace Artsoft.BusinessLogic
{
    public static class DiConfig
    {
        public static IServiceCollection ConfigureBusinessLogicServices(this IServiceCollection services)
        {
            return services
                    .AddScoped<IEmployeeService, EmployeeService>()
                    .AddScoped<IDepartmentService, DepartmentService>()
                    .AddScoped<IProgrammingLanguageService, ProgrammingLanguageService>()
                    .ConfigureDataAccessRepositories();
        }
    }
}