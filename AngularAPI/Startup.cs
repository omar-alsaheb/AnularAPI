using AngularAPI.Data;
using AngularAPI.Helpers;
using AngularAPI.Models;
using AngularAPI.Models.Identity;
using AngularAPI.Models.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI
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
            services.AddScoped<IConnectionMultiplexer>(c =>
            {
                var configuration = ConfigurationOptions.Parse(Configuration.GetConnectionString("Redis"));
                return ConnectionMultiplexer.Connect(configuration);
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); // To add AutoMapper and run it
            services.AddScoped<IServiceRepository<Product>, ProductRepository>();
            services.AddScoped<IServiceRepository<ProductBrand>, BrandsRepository>();
            services.AddScoped<IServiceRepository<ProductCategory>, CategoryRepository>();
            services.AddScoped<IBasketRepository, BasketRepositories>();
         
            services.AddControllers().AddNewtonsoftJson();
            //Omar Added this code 

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("constr"));
            });

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {


            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<ApplicationUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            });
            


            app.UseStaticFiles();
          
            
            app.UseHttpsRedirection();
          
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            MyIdentityDataSeed.SeedData(userManager, roleManager);
        }
    }
}
