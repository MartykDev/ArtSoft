using DaModels = Artsoft.DataAccess.Models.Entities;

namespace Artsoft.DataAccess.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<DaModels.Department>> GetAllAsync(CancellationToken cancellationToken);
    }
}