using DaModels = Artsoft.DataAccess.Models.Entities;
using DaCommands = Artsoft.DataAccess.Models.Commands;

namespace Artsoft.DataAccess.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task MergeAsync(DaCommands.EmployeeModifyCommand employeeModifyCommand, CancellationToken cancellationToken);
        Task<IEnumerable<DaModels.Employee>> GetAllAsync(CancellationToken cancellationToken);
        Task<DaModels.Employee> GetByIdAsync(Guid employeeId, CancellationToken cancellationToken);
        Task DeleteAsync(Guid employeeId, CancellationToken cancellationToken);
        Task<IEnumerable<string>> GetNamesAsync(string term, CancellationToken cancellationToken);
    }
}