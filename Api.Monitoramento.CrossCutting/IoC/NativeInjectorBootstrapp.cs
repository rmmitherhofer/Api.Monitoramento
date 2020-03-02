using Microsoft.Extensions.DependencyInjection;
using Api.Monitoramento.Application.Interface;
using Api.Monitoramento.Application.Services;
using Api.Monitoramento.Domain.Interface.Repository;
using Api.Monitoramento.Infra.Data.Repository;
using Api.Monitoramento.Infra.Data.Context;
using Api.Monitoramento.Domain.Interface.Service;
using Api.Monitoramento.Domain.Service;
using Api.Monitoramento.Domain.Models;
using Microsoft.AspNetCore.Http;
using Api.Monitoramento.Infra.Data.UoW;
using Api.Monitoramento.Infra.Data.ServiceExternal;

namespace Api.Monitoramento.CrossCutting.IoC
{
    public class NativeInjectorBootstrapp
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<MonitoramentoContext>();
            
            services.AddScoped<IHardwareAppService, HardwareAppService>();           

            services.AddScoped<IHardwareMonitoramentoService, HardwareMonitoramentoService>();
            services.AddScoped<IHardwareMonitoramentoLogService, HardwareMonitoramentoLogService>();

            services.AddScoped<IHardwareMonitoramentoRepository, HardwareMonitoramentoRepository>();
            services.AddScoped<IHardwareMonitoramentoLogRepository, HardwareMonitoramentoLogRepository>();

            services.AddScoped<IRepository<HardwareMonitoramento>, RepositorioBaseEF<HardwareMonitoramento>>();
            services.AddScoped<IRepository<HardwareMonitoramentoLog>, RepositorioBaseEF<HardwareMonitoramentoLog>>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ISmartAutoMatosApi, SmartAutoMatosApi>();
        }
    }
}
