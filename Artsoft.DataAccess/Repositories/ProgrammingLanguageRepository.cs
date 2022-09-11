using Common.Data.Interfaces;

using Artsoft.DataAccess.Repositories.Interfaces;

using DaModels = Artsoft.DataAccess.Models.Entities;

namespace Artsoft.DataAccess.Repositories
{
    public class ProgrammingLanguageRepository : IProgrammingLanguageRepository
    {
        private const string selectAllProgrammingLanguagesSpName = "spSelectAllProgrammingLanguages";

        private readonly IDatabaseClient databaseClient;

        public ProgrammingLanguageRepository(IDatabaseClient databaseClient)
            => this.databaseClient = databaseClient;

        public async Task<IEnumerable<DaModels.ProgrammingLanguage>> GetAllAsync(CancellationToken cancellationToken)
            => await databaseClient.ExecuteStoredProcedureAsync<DaModels.ProgrammingLanguage>(
                selectAllProgrammingLanguagesSpName, cancellationToken: cancellationToken);
    }
}