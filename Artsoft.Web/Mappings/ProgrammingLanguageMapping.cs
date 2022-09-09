using AutoMapper;

using WebModels = Artsoft.Web.Models;
using BlModels = Artsoft.BusinessLogic.Models;

namespace Artsoft.Web.Mappings
{
    public static class ProgrammingLanguageMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<BlModels.ProgrammingLanguage, WebModels.ProgrammingLanguage>();
        }
    }
}