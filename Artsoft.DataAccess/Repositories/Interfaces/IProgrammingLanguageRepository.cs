using DaModels = Artsoft.DataAccess.Models.Entities;

namespace Artsoft.DataAccess.Repositories.Interfaces
{
    public interface IProgrammingLanguageRepository
    {
        Task<IEnumerable<DaModels.ProgrammingLanguage>> GetAllAsync(CancellationToken cancellationToken);
    }
}