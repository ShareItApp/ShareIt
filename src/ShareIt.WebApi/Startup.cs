using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShareIt.Core;
using ShareIt.Data;
using ShareIt.Data.Auth.Entities;
using ShareIt.Global.Configuration;

namespace ShareIt.WebApi
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddDbContext<ApplicationDbContext>(this.configuration.GetDefaultConnectionString())
                .AddAutoMapper()
                .AddCoreServices();

            services
                .AddMvc()
                .AddFluentValidation(v => v.RegisterValidatorsFromAssemblyContaining<Startup>())
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddAuthentication();

            services
                .AddIdentityCore<User>(opts =>
                {
                    opts.Password.RequireDigit = false;
                    opts.Password.RequiredLength = 3;
                    opts.Password.RequireLowercase = false;
                    opts.Password.RequireUppercase = false;
                    opts.Password.RequireNonAlphanumeric = false;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<Data.Auth.IAuthManager, Data.Auth.AuthManager>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
