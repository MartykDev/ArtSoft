using AutoMapper;

using Common.Mapper.Extensions;

using DaModels = Artsoft.DataAccess.Models.Entities;

namespace Artsoft.DataAccess.Mappings
{
    public static class ProgrammingLanguageMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateDataReaderMap<DaModels.ProgrammingLanguage>();
        }
    }
}