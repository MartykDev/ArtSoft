using System.Data;
using System.Data.SqlClient;

using Common.Data.Interfaces;
using Common.Mapper.Extensions;

namespace Common.Data
{
    public class DatabaseClient : IDatabaseClient
    {
        private readonly string connectionString;

        public DatabaseClient(string connectionString)
            => this.connectionString = connectionString;

        public async Task ExecuteStoredProcedureAsync(string spName, IEnumerable<SqlParameter>? parameters = null, CancellationToken cancellationToken = default) 
        {
            await using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync(cancellationToken);

                await using (var command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters is not null)
                        command.Parameters.AddRange(parameters.ToArray());

                    await command.ExecuteNonQueryAsync(cancellationToken);
                }
            }
        }

        public async Task<IEnumerable<T>> ExecuteStoredProcedureAsync<T>(string spName, IEnumerable<SqlParameter>? parameters, CancellationToken cancellationToken) where T : class
        {
            var result = Enumerable.Empty<T>();

            await using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync(cancellationToken);

                await using (var command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters is not null)
                        command.Parameters.AddRange(parameters.ToArray());

                    await using (var reader = await command.ExecuteReaderAsync(cancellationToken))
                    {
                        result = await ReadToAsync<T>(reader);
                    }
                }
            }

            return result.ToList();
        }

        private async Task<IEnumerable<TTo>> ReadToAsync<TTo>(SqlDataReader dbDataReader) where TTo : class
        {
            var res = new List<TTo>();
            while (await dbDataReader.ReadAsync().ConfigureAwait(false))
            {
                res.Add(dbDataReader.MapTo<TTo>());
            }
            return res;
        }
    }
}