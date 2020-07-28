using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Sports_ORM.Models;

namespace Sports_ORM
{
    public class Startup
    {
        // This public getter will be how you access the data from appsettings.json
        // To access the connection string itself, you would use the following:
        // Configuration["DBInfo:ConnectionString"]
        public IConfiguration Configuration {get;}
        
        // Here we will "inject" the default IConfiguration service, which will bind to appsettings.json by default
        // and then assign it to the Configuration property.  This happens at the startup of our application.
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>(options => options.UseMySql(Configuration["DBInfo:ConnectionString"]));
            services.AddSession();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.UseMvc();
            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("Hello World!");
            // });
        }
    }
}
