using AutoMapper;

using Common.Mapper.Extensions;

namespace Artsoft.DataAccess.Mappings
{
    public static class ProgrammingLanguageMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateDataReaderMap<Models.ProgrammingLanguage>();
        }
    }
}