﻿using AutoMapper;

namespace Artsoft.Web.AppConfigs
{
    public static class MappingConfig
    {
        public static void Config(IMapperConfigurationExpression config)
        {
            BusinessLogic.MappingConfig.Config(config);
        }
    }
}