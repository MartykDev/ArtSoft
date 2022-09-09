using AutoMapper;

using Artsoft.Web.Mappings;

namespace Artsoft.Web.AppConfigs
{
    public static class MappingConfig
    {
        public static void Config(IMapperConfigurationExpression config)
        {
            EmployeeMapping.Mapping(config);
            ProgrammingLanguageMapping.Mapping(config);

            BusinessLogic.MappingConfig.Config(config);
        }
    }
}