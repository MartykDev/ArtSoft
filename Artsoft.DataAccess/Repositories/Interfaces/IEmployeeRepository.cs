using DaModels = Artsoft.DataAccess.Models.Entities;

namespace Artsoft.DataAccess.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<DaModels.Employee>> GetAllAsync(CancellationToken cancellationToken);
    }
}