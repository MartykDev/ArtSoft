using AutoMapper;
using AutoMapper.Data;

using Microsoft.Extensions.DependencyInjection;

namespace Common.Mapper
{
    public static class DiConfig
    {
        [Obsolete("I know static method AutoMapper.Mapper.Initialize() is deprecated but it is faster for development =)")]
        public static IServiceCollection AddMapping(this IServiceCollection services, Action<IMapperConfigurationExpression> mapConfig)
        {
            AutoMapper.Mapper.Initialize(cfg => 
            { 
                cfg.AddDataReaderMapping();
                mapConfig(cfg); 
            });
            return services;
        }
    }
}