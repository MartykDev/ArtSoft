using BlModels = Artsoft.BusinessLogic.Models;

namespace Artsoft.BusinessLogic.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<BlModels.Employee>> GetAllAsync(CancellationToken cancellationToken);
        Task<IEnumerable<string>> GetNamesAsync(string term, CancellationToken cancellationToken);
    }
}