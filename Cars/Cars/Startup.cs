using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Cars.Data;
using Cars.Data.Interface;
using Cars.Data.Mock;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Cars.Data.Repository;

namespace Cars
{
    public class Startup
    {

        private IConfigurationRoot _confsting;

        [Obsolete]
        public Startup(IHostingEnvironment hostEnv)
        {
            _confsting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("DbSettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_confsting.GetConnectionString("DefaultConnection")));
           
            services.AddTransient<ICar, CarRepository>();
            services.AddTransient<ICategory, CategoryRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                //template: "{controller=Home}/{action=StartPage}");    
                template: "{controller=Cars}/{action=ShowCarsByCategory}"); 
        });
        }
    }
}
