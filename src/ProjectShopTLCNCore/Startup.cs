using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProjectShopTLCNCore.Models;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Http;

namespace ProjectShopTLCNCore
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
               // builder.AddUserSecrets();

                // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
                builder.AddApplicationInsightsSettings(developerMode: true);
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);

			//services.AddDbContext<ApplicationDbContext>(options =>
			//    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

			var connection = @"Server=.;Database=ProjectShopAPI;Trusted_Connection=True;";
			services.AddDbContext<ProjectShopAPIContext>(options => options.UseSqlServer(connection));

			services.AddApplicationInsightsTelemetry(Configuration);

			//services.AddIdentity<ApplicationUser, IdentityRole>()
			//    .AddEntityFrameworkStores<ApplicationDbContext>()
			//    .AddDefaultTokenProviders();

			// config Section Areas
			services.Configure<RazorViewEngineOptions>(options =>
			{
				options.AreaViewLocationFormats.Clear();
				options.AreaViewLocationFormats.Add("/Admin/{2}/Views/{1}/{0}.cshtml");
				options.AreaViewLocationFormats.Add("/Admin/{2}/Views/Shared/{0}.cshtml");
				options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
			});

			services.AddMvc();

            // Add application services.

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseApplicationInsightsRequestTelemetry();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseApplicationInsightsExceptionTelemetry();

			app.UseDefaultFiles();
			app.UseStaticFiles();

            //app.UseIdentity();

            // Add external authentication middleware below. To configure them please see http://go.microsoft.com/fwlink/?LinkID=532715

            app.UseMvc(routes =>
            {
				routes.MapRoute(
					name: "areaRoute",
					template: "{area:exists}/{controller=Home}/{action=Index}");
				routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
