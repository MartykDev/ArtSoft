using Common.Data.Interfaces;

using Artsoft.DataAccess.Repositories.Interfaces;

using DaModels = Artsoft.DataAccess.Models.Entities;

namespace Artsoft.DataAccess.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private const string selectAllEmployeesSpName = "spSelectAllEmployees";

        private readonly IDatabaseClient databaseClient;

        public EmployeeRepository(IDatabaseClient databaseClient)
            => this.databaseClient = databaseClient;

        public async Task<IEnumerable<DaModels.Employee>> GetAllAsync(CancellationToken cancellationToken)
            => await databaseClient.ExecuteStoredProcedureAsync<DaModels.Employee>(
                selectAllEmployeesSpName, cancellationToken: cancellationToken);
    }
}