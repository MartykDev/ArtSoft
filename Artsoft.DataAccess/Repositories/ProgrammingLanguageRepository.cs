using Common.Data.Interfaces;

using Artsoft.DataAccess.Repositories.Interfaces;

using DaModels = Artsoft.DataAccess.Models;
using Artsoft.DataAccess.Models.Entities;

namespace Artsoft.DataAccess.Repositories
{
    public class ProgrammingLanguageRepository : IProgrammingLanguageRepository
    {
        private const string selectAllProgrammingLanguagesSpName = "spSelectAllProgrammingLanguages";

        private readonly IDatabaseClient databaseClient;

        public ProgrammingLanguageRepository(IDatabaseClient databaseClient)
            => this.databaseClient = databaseClient;

        public async Task<IEnumerable<ProgrammingLanguage>> GetAllAsync(CancellationToken cancellationToken)
            => await databaseClient.ExecuteStoredProcedureAsync<ProgrammingLanguage>(
                selectAllProgrammingLanguagesSpName, cancellationToken: cancellationToken);
    }
}