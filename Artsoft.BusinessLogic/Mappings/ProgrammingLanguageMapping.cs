using AutoMapper;

using BlModels = Artsoft.BusinessLogic.Models;
using DaModels = Artsoft.DataAccess.Models;

namespace Artsoft.BusinessLogic.Mappings
{
    public static class ProgrammingLanguageMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<DaModels.ProgrammingLanguage, BlModels.ProgrammingLanguage>();
        }
    }
}
