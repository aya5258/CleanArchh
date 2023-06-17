using CleanArch.Application.AutoMappers;

namespace CleanArchh.MVC.Configurations
{
    public static class AutoMapperCongig
    {

        public static void RegisterAutoMapper(this IServiceCollection Service)
        {
            Service.AddAutoMapper(typeof(CleanArch.Application.AutoMappers.AutoMapperConfigurations));
            AutoMapperConfigurations.RegisterMappings();

        }
    }
}
