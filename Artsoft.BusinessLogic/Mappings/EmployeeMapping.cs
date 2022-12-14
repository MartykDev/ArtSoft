using AutoMapper;

using Artsoft.BusinessLogic.Enums;

using BlModels = Artsoft.BusinessLogic.Models;
using DaModels = Artsoft.DataAccess.Models.Entities;
using DaCommands = Artsoft.DataAccess.Models.Commands;
using BlCommands = Artsoft.BusinessLogic.Models.Commands;

namespace Artsoft.BusinessLogic.Mappings
{
    public class EmployeeMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<DaModels.Employee, BlModels.Employee>()
                  .ForMember(bl => bl.Gender, opt => opt.MapFrom(da => (Gender)da.Gender));

            config.CreateMap<BlCommands.EmployeeModifyCommand, DaCommands.EmployeeModifyCommand>()
                  .ForMember(bl => bl.Gender, opt => opt.MapFrom(da => (int)da.Gender));
        }
    }
}