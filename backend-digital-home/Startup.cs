using backend_digital_home.Managers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using backend_digital_home.Core.DataProviders;
using backend_digital_home.Core.Managers;
using backend_digital_home.Core.Models;
using backend_digital_home.Data.Models;
using backend_digital_home.DataProviders;
using backend_digital_home.Core;
using backend_digital_home.Data;

namespace backend_digital_home
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
            services.AddSingleton<IConnectionHelper, ConnectionHelper>();
            services.AddTransient<IMovie, Movie>();
            services.AddTransient<IMovieManager, MovieManager>();
            services.AddTransient<IMovieDataProvider, MovieDataProvider>();
            services.AddTransient<IGenre, Genre>();
            services.AddTransient<IGenreManager, GenreManager>();
            services.AddTransient<IGenreDataProvider, GenreDataProvider>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
