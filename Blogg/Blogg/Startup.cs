using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Blogg.Models;
using Microsoft.Extensions.Configuration;

namespace Blogg
{
    public class Startup
    {
        //för att lägga connectionstringen i en config-fil så behöver jag injecta IConfiguration
        private IConfiguration Configuration;

        public Startup(IConfiguration config)
        {
            Configuration = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var conn = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<BlogDBContext>(options => options.UseSqlServer(conn));

            services.AddSession();
            services.AddDistributedMemoryCache();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "Default",
                template: "{controller=Home}/{action=ListView}");
            });
        }
    }
}
