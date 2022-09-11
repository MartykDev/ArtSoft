using System.Data;
using System.Data.SqlClient;

using Common.Data.Interfaces;

using Artsoft.DataAccess.Repositories.Interfaces;

using DaModels = Artsoft.DataAccess.Models.Entities;
using DaCommands = Artsoft.DataAccess.Models.Commands;

namespace Artsoft.DataAccess.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        #region SpNames

        private const string mergeEmployeesSpName = "spMergeEmployees";
        private const string deleteEmployeeSpName = "spDeleteEmployee";
        private const string selectByIdEmployeeSpName = "spSelectByIdEmployee";
        private const string selectAllEmployeesSpName = "spSelectAllEmployees";

        #endregion

        private readonly IDatabaseClient databaseClient;

        public EmployeeRepository(IDatabaseClient databaseClient)
            => this.databaseClient = databaseClient;

        public async Task MergeAsync(DaCommands.EmployeeModifyCommand employeeModifyCommand, CancellationToken cancellationToken)
            => await databaseClient.ExecuteStoredProcedureAsync(
                mergeEmployeesSpName, GetSqlParameters(new[] { employeeModifyCommand }),
                cancellationToken);

        public async Task<IEnumerable<DaModels.Employee>> GetAllAsync(CancellationToken cancellationToken)
            => await databaseClient.ExecuteStoredProcedureAsync<DaModels.Employee>(
               selectAllEmployeesSpName, cancellationToken: cancellationToken);

        public async Task<DaModels.Employee> GetByIdAsync(Guid employeeId, CancellationToken cancellationToken)
            => (await databaseClient.ExecuteStoredProcedureAsync<DaModels.Employee>(
                selectByIdEmployeeSpName, new[] { new SqlParameter("@employeeId", employeeId) }, 
                cancellationToken: cancellationToken)).FirstOrDefault();

        public async Task DeleteAsync(Guid employeeId, CancellationToken cancellationToken)
            => await databaseClient.ExecuteStoredProcedureAsync(
                deleteEmployeeSpName, new[] { new SqlParameter("@employeeId", employeeId) }, 
                cancellationToken: cancellationToken);


        #region Private

        private IEnumerable<SqlParameter> GetSqlParameters(IEnumerable<DaCommands.EmployeeModifyCommand> commands)
        {
            //TODO Remake on reflection

            var dataTable = new DataTable();
            dataTable.Columns.Add(nameof(DaCommands.EmployeeModifyCommand.Id), typeof(Guid));
            dataTable.Columns.Add(nameof(DaCommands.EmployeeModifyCommand.Name), typeof(string));
            dataTable.Columns.Add(nameof(DaCommands.EmployeeModifyCommand.Surname), typeof(string));
            dataTable.Columns.Add(nameof(DaCommands.EmployeeModifyCommand.Age), typeof(int));
            dataTable.Columns.Add(nameof(DaCommands.EmployeeModifyCommand.Gender), typeof(int));
            dataTable.Columns.Add(nameof(DaCommands.EmployeeModifyCommand.DepartmentId), typeof(Guid));
            dataTable.Columns.Add(nameof(DaCommands.EmployeeModifyCommand.ProgrammingLanguageId), typeof(Guid));

            foreach (var command in commands)
            {
                dataTable.Rows.Add(
                    command.Id, 
                    command.Name, 
                    command.Surname, 
                    command.Age, 
                    command.Gender, 
                    command.DepartmentId, 
                    command.ProgrammingLanguageId);
            }

            var parameter = new SqlParameter("@employee", dataTable);

            return new[] { parameter };
        }

        #endregion
    }
}