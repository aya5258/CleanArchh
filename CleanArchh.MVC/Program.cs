using CleaArch.IOC;
using CleanArch.infra.Data.Context;
using CleanArchh.MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace CleanArchh.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<AplicationDBContext>(options =>

            { options.UseSqlServer(builder.Configuration.GetConnectionString("Con")); });



               RegisterServices(builder.Services);

            builder.Services.AddDbContext<UniversityDBContext>(options =>

            { options.UseSqlServer(builder.Configuration.GetConnectionString("Con2")); });


         

             var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            DependancyLoader.RegisterServices(services);
        }
    }
}