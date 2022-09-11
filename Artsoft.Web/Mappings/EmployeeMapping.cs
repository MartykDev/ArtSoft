using AutoMapper;

using WebModels = Artsoft.Web.Models;
using BlModels = Artsoft.BusinessLogic.Models;
using BlCommands = Artsoft.BusinessLogic.Models.Commands;

namespace Artsoft.Web.Mappings
{
    public class EmployeeMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<BlModels.Employee, WebModels.Employee>()
                  .ForMember(bl => bl.Gender, opt => opt.MapFrom(da => da.Gender.ToString()));

            config.CreateMap<WebModels.EmployeeModifyInput, BlCommands.EmployeeModifyCommand>()
                  .ForMember(bl => bl.Gender, opt => opt.MapFrom(da => Enum.Parse<BusinessLogic.Enums.Gender>(da.Gender)));
        }
    }
}
