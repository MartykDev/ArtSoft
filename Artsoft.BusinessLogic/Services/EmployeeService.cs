using Common.Mapper.Extensions;

using Artsoft.BusinessLogic.Services.Interfaces;
using Artsoft.DataAccess.Repositories.Interfaces;

using BlModels = Artsoft.BusinessLogic.Models;
using DaCommands = Artsoft.DataAccess.Models.Commands;
using BlCommands = Artsoft.BusinessLogic.Models.Commands;

namespace Artsoft.BusinessLogic.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
            => this.employeeRepository = employeeRepository;

        public async Task<IEnumerable<BlModels.Employee>> GetAllAsync(CancellationToken cancellationToken)
            => (await employeeRepository.GetAllAsync(cancellationToken)).MapRangeTo<BlModels.Employee>();

        public async Task CreateAsync(BlCommands.EmployeeModifyCommand employeeModifyCommand, CancellationToken cancellationToken)
        {
            var daMergeCommand = employeeModifyCommand.MapTo<DaCommands.EmployeeModifyCommand>();
            daMergeCommand.Id = Guid.NewGuid();

            await employeeRepository.MergeAsync(daMergeCommand, cancellationToken);
        }

        public async Task UpdateAsync(Guid employeeId, BlCommands.EmployeeModifyCommand employeeModifyCommand, CancellationToken cancellationToken)
        {
            var daMergeCommand = employeeModifyCommand.MapTo<DaCommands.EmployeeModifyCommand>();
            daMergeCommand.Id = employeeId;

            await employeeRepository.MergeAsync(daMergeCommand, cancellationToken);
        }

        public Task DeleteAsync(Guid employeeId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<BlModels.Employee> GetByIdAsync(Guid employeeId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string>> GetNamesAsync(string term, CancellationToken cancellationToken)
           => throw new NotImplementedException();
    }
}