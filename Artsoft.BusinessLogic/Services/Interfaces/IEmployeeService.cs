using BlModels = Artsoft.BusinessLogic.Models;
using BlCommands = Artsoft.BusinessLogic.Models.Commands;

namespace Artsoft.BusinessLogic.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task CreateAsync(BlCommands.EmployeeModifyCommand employeeModifyCommand, CancellationToken cancellationToken);
        Task UpdateAsync(Guid employeeId, BlCommands.EmployeeModifyCommand employeeModifyCommand, CancellationToken cancellationToken);
        Task DeleteAsync(Guid employeeId, CancellationToken cancellationToken);
        Task<BlModels.Employee> GetByIdAsync(Guid employeeId, CancellationToken cancellationToken);
        Task<IEnumerable<BlModels.Employee>> GetAllAsync(CancellationToken cancellationToken);
        Task<IEnumerable<string>> GetNamesAsync(string term, CancellationToken cancellationToken);
    }
}