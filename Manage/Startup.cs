using AutoMapper;
using Core;
using Core.Services;
using Data;
using FluentValidation;
using FluentValidation.AspNetCore;
using Manage.DTO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Data;

namespace Manage
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<MusicAppContext>(options =>
                   options.UseSqlServer(Configuration.GetConnectionString("Default"),
                   x => x.MigrationsAssembly("Data")));


            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IArtistService, ArtistService>();

            services.AddMvc(setup =>
            {
                //...mvc setup...
            }).AddFluentValidation();

            services.AddTransient<IValidator<ArtistCreateDto>, ArtistCreateDtoValidator>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
