using CleaArch.IOC;
using CleanArch.Api.Configurations;
using CleanArch.infra.Data.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();


            builder.Services.AddDbContext<UniversityDBContext>(options =>

            { options.UseSqlServer(builder.Configuration.GetConnectionString("Con2")); });


            RegisterServices(builder.Services);
            builder.Services.AddMediatR();
            builder.Services.RegisterAutoMapper();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


           

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
        private static void RegisterServices(IServiceCollection services)
        {
            DependancyLoader.RegisterServices(services);

        }
    }
}