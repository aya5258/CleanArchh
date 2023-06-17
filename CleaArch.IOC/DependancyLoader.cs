using CleanArch.Application.interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.infra.Data.Context;
using CleanArch.infra.Data.Repository;
using CleanArch.Infra.Bus;
using MediatR;
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


            //Domain Inmemory MediatR
            Services.AddScoped<IMediatorHandler, InMemoryBus>();
            //ApplicationLayer
            Services.AddScoped<ICourseService, CourseService>();



            //Domain Handlers
            Services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();


            //infra.Data layer
            Services.AddScoped<ICourseRepository, CourseRepository>();
      

            Services.AddScoped<UniversityDBContext>();
        }
    }
}
