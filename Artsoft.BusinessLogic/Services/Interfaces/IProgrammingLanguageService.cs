using BlModels = Artsoft.BusinessLogic.Models;

namespace Artsoft.BusinessLogic.Services.Interfaces
{
    public interface IProgrammingLanguageService
    {
        Task<IEnumerable<BlModels.ProgrammingLanguage>> GetAllAsync(CancellationToken cancellationToken);
    }
}