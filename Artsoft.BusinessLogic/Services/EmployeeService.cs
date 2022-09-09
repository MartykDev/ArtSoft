using Common.Mapper.Extensions;

using Artsoft.BusinessLogic.Services.Interfaces;
using Artsoft.DataAccess.Repositories.Interfaces;

using BlModels = Artsoft.BusinessLogic.Models;

namespace Artsoft.BusinessLogic.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
            => this.employeeRepository = employeeRepository;

        public async Task<IEnumerable<BlModels.Employee>> GetAllAsync(CancellationToken cancellationToken)
            => (await employeeRepository.GetAllAsync(cancellationToken)).MapRangeTo<BlModels.Employee>();

        public async Task<IEnumerable<string>> GetNamesAsync(string term, CancellationToken cancellationToken)
            => throw new NotImplementedException();
    }
}