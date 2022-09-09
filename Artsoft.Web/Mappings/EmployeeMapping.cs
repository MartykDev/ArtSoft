using AutoMapper;

using WebModels = Artsoft.Web.Models;
using BlModels = Artsoft.BusinessLogic.Models;

namespace Artsoft.Web.Mappings
{
    public class EmployeeMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<BlModels.Employee, WebModels.Employee>()
                  .ForMember(bl => bl.Gender, opt => opt.MapFrom(da => da.Gender.ToString()));
        }
    }
}
