using Common.Data;
using Common.Mapper;

using Artsoft.Web.Data;
using Artsoft.Web.Constants;
using Artsoft.Web.AppConfigs;
using Artsoft.BusinessLogic.Services;
using Artsoft.DataAccess.Repositories;
using Artsoft.BusinessLogic.Services.Interfaces;
using Artsoft.DataAccess.Repositories.Interfaces;

namespace Artsoft.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDatabaseClient(DatabaseConnections.MasterConnectionString);

            builder.Services.AddScoped<IProgrammingLanguageRepository, ProgrammingLanguageRepository>();
            builder.Services.AddScoped<IProgrammingLanguageService, ProgrammingLanguageService>();

            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddMapping(MappingConfig.Config);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}