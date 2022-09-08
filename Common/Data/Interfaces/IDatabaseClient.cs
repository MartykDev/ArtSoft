using System.Data.SqlClient;

namespace Common.Data.Interfaces
{
    public interface IDatabaseClient
    {
        Task ExecuteStoredProcedureAsync(string spName, IEnumerable<SqlParameter>? parameters, CancellationToken cancellationToken);
        Task<IEnumerable<T>> ExecuteStoredProcedureAsync<T>(string spName, IEnumerable<SqlParameter>? parameters = null, CancellationToken cancellationToken = default) where T : class;
    }
}