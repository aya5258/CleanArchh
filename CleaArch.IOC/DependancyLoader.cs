using CleanArch.Application.interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaArch.IOC
{
    public class DependancyLoader
    {
        public static void RegisterServices(IServiceCollection Services)
        {
            //ApplicationLayer
            Services.AddScoped<ICourseService,CourseService>();

            //infra.Data layer
            Services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
