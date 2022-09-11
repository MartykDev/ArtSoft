using Common.Data.Interfaces;

using Artsoft.DataAccess.Repositories.Interfaces;

using DaModels = Artsoft.DataAccess.Models.Entities;

namespace Artsoft.DataAccess.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private const string selectAllDepartmentsSpName = "spSelectAllDepartments";

        private readonly IDatabaseClient databaseClient;

        public DepartmentRepository(IDatabaseClient databaseClient)
            => this.databaseClient = databaseClient;

        public async Task<IEnumerable<DaModels.Department>> GetAllAsync(CancellationToken cancellationToken)
            => await databaseClient.ExecuteStoredProcedureAsync<DaModels.Department>(
                selectAllDepartmentsSpName, cancellationToken: cancellationToken);
    }
}