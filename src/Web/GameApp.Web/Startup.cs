﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Data.Models;
using GameApp.Web.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameApp.Web.Models;
using GameApp.Web.Services;
using GameApp.Web.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameApp.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddDbContext<GameAppContext>(options =>
                options.UseSqlServer(
                    this.Configuration.GetConnectionString("DefaultConnection")));

            //Working with Administrator role 
            services.AddDefaultIdentity<GameAppUser>(opt =>
                {
                    opt.Password.RequireDigit = false;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequiredLength = 3;
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequiredUniqueChars = 0;
                    opt.Password.RequireUppercase = false;
                }).AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<GameAppContext>();


            //services.AddDefaultIdentity<GameAppUser>(opt =>
            //    {
            //        opt.Password.RequireDigit = false;
            //        opt.Password.RequireLowercase = false;
            //        opt.Password.RequiredLength = 3;
            //        opt.Password.RequireNonAlphanumeric = false;
            //        opt.Password.RequireUppercase = false;
            //        opt.Password.RequiredUniqueChars = 0;

            //    })
            //    .AddEntityFrameworkStores<GameAppContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //Application services
            services.AddScoped<IHomeService,HomeService>();
            services.AddScoped<IGameService,GameService>();
            services.AddScoped<ICategoryService,CategoryService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider provider, UserManager<GameAppUser> userManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //Seed roles and user in that role
            //RoleSeeder.Seed(provider, userManager);

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();
    
            app.UseMvc(routes =>
            {

                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

             

            });
        }
    }
}
