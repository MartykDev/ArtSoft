using Artsoft.DataAccess.Models.Entities;
using AutoMapper;

using Common.Mapper.Extensions;

using DaModels = Artsoft.DataAccess.Models;

namespace Artsoft.DataAccess.Mappings
{
    public static class ProgrammingLanguageMapping
    {
        public static void Mapping(IMapperConfigurationExpression config)
        {
            config.CreateDataReaderMap<ProgrammingLanguage>();
        }
    }
}