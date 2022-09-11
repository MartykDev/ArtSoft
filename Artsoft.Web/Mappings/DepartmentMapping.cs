using AutoMapper;

using WebModels = Artsoft.Web.Models;
using BlModels = Artsoft.BusinessLogic.Models;

namespace Artsoft.Web.Mappings
{
    public static class DepartmentMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<BlModels.Department, WebModels.Department>();
        }
    }
}