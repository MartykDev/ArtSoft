using Common.Mapper.Extensions;

using Artsoft.BusinessLogic.Services.Interfaces;
using Artsoft.DataAccess.Repositories.Interfaces;

using BlModels = Artsoft.BusinessLogic.Models;

namespace Artsoft.BusinessLogic.Services
{
    public class ProgrammingLanguageService : IProgrammingLanguageService
    {
        private readonly IProgrammingLanguageRepository programmingLanguageRepository;

        public ProgrammingLanguageService(IProgrammingLanguageRepository programmingLanguageRepository)
            => this.programmingLanguageRepository = programmingLanguageRepository;

        public async Task<IEnumerable<BlModels.ProgrammingLanguage>> GetAllAsync(CancellationToken cancellationToken)
            => (await programmingLanguageRepository.GetAllAsync(cancellationToken)).MapRangeTo<BlModels.ProgrammingLanguage>();
    }
}