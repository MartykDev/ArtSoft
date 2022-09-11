using System.Data.SqlClient;

using Common.Mapper.Extensions;

namespace Common.Data.Extensions
{
    public static class SqlDataReaderExtensions
    {
        public static async Task<IEnumerable<TTo>> ReadToAsync<TTo>(this SqlDataReader dbDataReader, CancellationToken cancellationToken) where TTo : class
        {
            var result = new List<TTo>();

            while (await dbDataReader.ReadAsync(cancellationToken).ConfigureAwait(false))
            {
                result.Add(dbDataReader.MapTo<TTo>());
            }

            return result;
        }
    }
}