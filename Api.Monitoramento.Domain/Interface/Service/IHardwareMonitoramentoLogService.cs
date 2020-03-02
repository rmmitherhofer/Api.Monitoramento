using Api.Monitoramento.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Monitoramento.Domain.Interface.Service
{
    public interface IHardwareMonitoramentoLogService
    {
        void Incluir(HardwareMonitoramento hardwareMonitoramento, string tipoOperacao);
    }
}
