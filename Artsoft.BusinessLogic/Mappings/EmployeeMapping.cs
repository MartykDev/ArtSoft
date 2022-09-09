using AutoMapper;

using Artsoft.BusinessLogic.Enums;

using BlModels = Artsoft.BusinessLogic.Models;
using DaModels = Artsoft.DataAccess.Models.Entities;

namespace Artsoft.BusinessLogic.Mappings
{
    public class EmployeeMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<DaModels.Employee, BlModels.Employee>()
                  .ForMember(bl => bl.Gender, opt => opt.MapFrom(da => (Gender)da.Gender))
                  .ForMember(bl => bl.DepartmentName, opt => opt.MapFrom(da => da.Department.Name))
                  .ForMember(bl => bl.ProgrammingLanguageName, opt => opt.MapFrom(da => da.ProgrammingLanguage.Name));

        }
    }
}