using AutoMapper;

using Artsoft.DataAccess.Mappings;

namespace Artsoft.DataAccess
{
    public static class MappingConfig
    {
        public static void Config(IMapperConfigurationExpression config)
        {
            EmployeeMapping.Mapping(config);
            ProgrammingLanguageMapping.Mapping(config);
        }
    }
}