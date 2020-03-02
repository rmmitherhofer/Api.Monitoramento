using Api.Monitoramento.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Monitoramento.Domain.Interface.Repository
{
    public interface IHardwareMonitoramentoRepository
    {
        HardwareMonitoramento ObterHardwareMonitorado(string NumeroDeSerie);
    }
}
