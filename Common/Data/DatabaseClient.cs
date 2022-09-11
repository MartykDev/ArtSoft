using System.Data;
using System.Data.SqlClient;

using Common.Data.Extensions;
using Common.Data.Interfaces;

namespace Common.Data
{
    public class DatabaseClient : IDatabaseClient
    {
        private readonly string connectionString;

        public DatabaseClient(string connectionString)
            => this.connectionString = connectionString;

        public async Task ExecuteStoredProcedureAsync(string spName, IEnumerable<SqlParameter>? parameters = null, CancellationToken cancellationToken = default) 
            => await ExecuteCommandAsync(spName, parameters, cancellationToken: cancellationToken);

        //TODO Remake on IAsyncEnumerable<T>
        public async Task<IEnumerable<T>> ExecuteStoredProcedureAsync<T>(string spName, IEnumerable<SqlParameter>? parameters, CancellationToken cancellationToken) where T : class
        {
            var result = Enumerable.Empty<T>();

            await ExecuteCommandAsync(spName, parameters, async (reader) => 
            {
                result = await reader.ReadToAsync<T>(cancellationToken);
            }, cancellationToken: cancellationToken);

            return result.ToList();
        }

        #region Private

        private async Task ExecuteCommandAsync(string spName, IEnumerable<SqlParameter>? parameters = null, Func<SqlDataReader, Task>? readerCallback = null!, CancellationToken cancellationToken = default)
        {
            await using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync(cancellationToken);

                await using (var command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters is not null)
                        command.Parameters.AddRange(parameters.ToArray());

                    if (readerCallback is not null)
                    {
                        await using (var reader = await command.ExecuteReaderAsync(cancellationToken))
                        {
                            await readerCallback.Invoke(reader);
                            return;
                        }
                    }

                    await command.ExecuteNonQueryAsync(cancellationToken);
                }
            }
        }
        
        #endregion
    }
}