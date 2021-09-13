using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VideoGameMetadataApi.Utilities;
using VideoGameMetadataApi.Core.DataProviders;
using VideoGameMetadataApi.Core.Services;
using VideoGameMetadataApi.Model;
using VideoGameMetadataApi.Services;
using VideoGameMetdataApi.DataProviders;

namespace VideoGameMetadataApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(opts => opts.Filters.Add(new AuthorizeFilter()));

            services.AddSwaggerGen(opts =>
                opts.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Video Game Metadata API" })
            );

#pragma warning disable HAA0101 // Array allocation for params parameter
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
#pragma warning restore HAA0101 // Array allocation for params parameter

            services.AddDbContext<VideoGameDbContext>(options =>
                {
                    options.UseInMemoryDatabase(databaseName: "In-Mem Video");
                });
            //TODO: need to load in data from data.json


            // Services (Business-Logic)
            services.AddScoped<IGameService, GameService>();


            // Data Providers (Data-Logic)
            services.AddScoped<IGameDataProvider, GameDataProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(config => config.SwaggerEndpoint("/swagger/v1/swagger.json", "Video Game Metadata API"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
