using AutoMapper;

using BlModels = Artsoft.BusinessLogic.Models;
using DaModels = Artsoft.DataAccess.Models.Entities;

namespace Artsoft.BusinessLogic.Mappings
{
    public static class DepartmentMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<DaModels.Department, BlModels.Department>();
        }
    }
}