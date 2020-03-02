using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Api.Monitoramento.Infra.Data.Context;
using System.Diagnostics;

namespace Api.Monitoramento.CrossCutting.ContextConfig
{
    public class ContextConfig
    {
        public ContextConfig(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void RegisterContext(IServiceCollection services)
        {            
            string connectionString = Configuration.GetConnectionString("MonitoramentoTeste");

            services.AddDbContext<MonitoramentoContext>(options =>
                options.UseSqlServer(connectionString)
            );
        }
    }
}
