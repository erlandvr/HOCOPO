using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Hocopo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseNodeModules(env);

            //UseMvc: listens to request and maps them to a Controller
            app.UseMvc(cfg =>
            //routes setup
            {
                cfg.MapRoute("Default", "/{controller}/{action}/{id?}",/*gives us a default route to chose when controller and action are missing in the url ->*/ new { controller = "App", Action = "Index" });
            });
        }
    }
}
