using BlModels = Artsoft.BusinessLogic.Models;

namespace Artsoft.BusinessLogic.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task<IEnumerable<BlModels.Department>> GetAllAsync(CancellationToken cancellationToken);
    }
}