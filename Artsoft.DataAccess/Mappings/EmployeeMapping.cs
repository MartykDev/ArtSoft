using AutoMapper;

using Common.Mapper.Extensions;

using DaModels = Artsoft.DataAccess.Models.Entities;

namespace Artsoft.DataAccess.Mappings
{
    public static class EmployeeMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateDataReaderMap<DaModels.Employee>();
        }
    }
}