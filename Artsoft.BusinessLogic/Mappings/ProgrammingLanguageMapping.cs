using AutoMapper;

using BlModels = Artsoft.BusinessLogic.Models;
using DaModels = Artsoft.DataAccess.Models.Entities;

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
