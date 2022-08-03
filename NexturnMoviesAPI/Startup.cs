using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NexturnMovies.Business;
using NexturnMovies.Business.Interfaces;
using NexturnMovies.Repository;
using NexturnMovies.Repository.Interfaces;
using NexturnMovies.Repository.Models;
using NexturnMovies.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NexturnMoviesAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NexturnMoviesAPI", Version = "v1" });
            });
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<movieBookingContext>(options => options.UseSqlServer(connectionString));
            services.AddDbContext<myContext>(options => options.UseSqlServer(connectionString));

            services.AddSession();
            services.AddTransient<IMovieBusiness, MovieBusiness>();
            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddControllersWithViews();
            services.AddHttpClient();
            services.AddMemoryCache();
            //Automapper
            services.AddAutoMapper(typeof(AutoMappingConfig));


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NexturnMoviesAPI v1"));
            }

            app.UseRouting();

            //CORS
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
