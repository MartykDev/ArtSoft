using AutoMapper;

using Artsoft.BusinessLogic.Mappings;

namespace Artsoft.BusinessLogic
{
    public static class MappingConfig
    {
        public static void Config(IMapperConfigurationExpression config)
        {
            ProgrammingLanguageMapping.Mapping(config);

            DataAccess.MappingConfig.Config(config);
        }
    }
}