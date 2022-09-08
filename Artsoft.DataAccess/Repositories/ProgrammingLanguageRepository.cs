using Common.Data.Interfaces;

using Artsoft.DataAccess.Models;
using Artsoft.DataAccess.Repositories.Interfaces;

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