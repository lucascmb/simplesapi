using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBahia.Persistence.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DesafioBahia.Persistence.Repositories;
using DesafioBahia.Domain.Repositories;
using DesafioBahia.Domain.Services;
using DesafioBahia.Services;
using AutoMapper;
using DesafioBahia.Domain.Validator;
using DesafioBahia.Extensions.Validator;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;

namespace DesafioBahia
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<DBContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("BahiaDesafioContext"));
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IAtivoRepository, AtivoRepository>();
            services.AddScoped<IAtivoService, AtivoService>();

            services.AddScoped<IOrdemRepository, OrdemRepository>();
            services.AddScoped<IOrdemService, OrdemService>();
            services.AddScoped<IOrdemValidator, OrdemValidator>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "DesafioBahiaAPI",
                    Version = "v1",
                    Description = "API do Desafio Bahia",
                    Contact = new OpenApiContact
                    {
                        Name = "Lucas Clemente",
                        Email = "lucas.cmb03@gmail.com",
                        Url = new Uri("https://github.com/lucascmb/simplesapi")
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
