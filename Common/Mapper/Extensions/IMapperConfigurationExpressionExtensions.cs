using AutoMapper;

using System.Data.Common;

namespace Common.Mapper.Extensions
{
    public static class IMapperConfigurationExpressionExtensions
    {
        public static void CreateDataReaderMap<TTo>(this IMapperConfigurationExpression config) where TTo : class
        {
            config.CreateMap<DbDataReader, TTo>();
        }
    }
}