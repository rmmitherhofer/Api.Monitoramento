using Api.Monitoramento.Domain.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Monitoramento.Infra.Data.ServiceExternal
{
    public interface ISmartAutoMatosApi
    {
        Task<IEnumerable<HardwareMonitoramentoApi>> ChamarAPISmartAutoMatosAsync();
    }
}
