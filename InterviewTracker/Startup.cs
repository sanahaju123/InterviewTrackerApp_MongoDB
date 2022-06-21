using InterviewTrack.BusinessLayer.Interfaces;
using InterviewTracker.BusinessLayer.Interfaces;
using InterviewTracker.BusinessLayer.Services;
using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.DataLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTracker
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
            services.AddControllersWithViews();
            services.AddMvc(options => options.EnableEndpointRouting = false).
                SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.Configure<Mongosettings>(Options =>
            {
              Options.Connection = Configuration.GetSection("MongoConnection:Connection").Value;
              Options.DatabaseName = Configuration.GetSection("MongoConnection:DatabaseName").Value;
            });
            //Injecting Services and Repository
            services.AddScoped<IMongoDBContext, MongoDBContext>();
            services.AddScoped<IUserInterviewTrackerRepository, UserInterviewTrackerRepository>();
            services.AddScoped<IUserInterviewTrackerServices, UserInterviewTrackerServices>();
            services.AddScoped<IInterviewTrackerRepository, InterviewTrackerRepository>();
            services.AddScoped<IInterviewTrackerServices, InterviewTrackerServices>();
            // using Cors policy provide web application running at one origin
            services.AddCors(options =>
            {
              options.AddPolicy("CorsPolicy",
                  builder => builder.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader()
                      .AllowCredentials());
            });
    }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
