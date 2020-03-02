using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Api.Monitoramento.Application.Services;
using Swashbuckle.AspNetCore.Swagger;
using Api.Monitoramento.CrossCutting.IoC;
using Api.Monitoramento.CrossCutting.ContextConfig;
using Api.Monitoramento.Application.Filtros;
using Microsoft.OpenApi.Models;

namespace Api.Monitoramento.WebApi
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
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ErrorResponseFilter));
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            #region Versionamento
            services.AddApiVersioning();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Monitoramento API",
                    Description = "Documentação da API de Monitoramento",
                    Version = "1.0"
                });

                options.EnableAnnotations();
                options.DescribeAllParametersInCamelCase();
            });
            #endregion
            services.AddHttpContextAccessor();

            RegisterService(services, Configuration);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(x =>
            {
                ///API/Monitoramento
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "Versão 1.0");
            });
        }

        private static void RegisterService(IServiceCollection services, IConfiguration configuration)
        {
            NativeInjectorBootstrapp.RegisterServices(services);
            ContextConfig context = new ContextConfig(configuration);
            context.RegisterContext(services);
        }
    }
}
