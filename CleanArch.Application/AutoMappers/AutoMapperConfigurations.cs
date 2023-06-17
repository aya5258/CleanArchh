using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.AutoMappers
{
    public class AutoMapperConfigurations
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(new DomainToViewModelProfile());
                    cfg.AddProfile(new DomainToViewModelProfile());
                });

             
        }
    }
}
