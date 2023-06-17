
using CleanArch.Application.AutoMappers;

namespace CleanArch.Api.Configurations
{
    public static  class AutoMapperConfig
    {

        public static void RegisterAutoMapper(this IServiceCollection  Service)
        {
            Service.AddAutoMapper(typeof(CleanArch.Application.AutoMappers.AutoMapperConfigurations));
            AutoMapperConfigurations.RegisterMappings();

        }
    }
}
