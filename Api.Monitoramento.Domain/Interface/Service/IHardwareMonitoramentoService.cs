using Api.Monitoramento.Domain.Models;
using System.Collections.Generic;

namespace Api.Monitoramento.Domain.Interface.Service
{
    public interface IHardwareMonitoramentoService
    {
        HardwareMonitoramento ValidarHardwareMonitorado(string numeroSerie);
        void Incluir(HardwareMonitoramento hardwareMonitoramento);
        void Alterar(HardwareMonitoramento hardwareMonitoramento, bool atualizado);
        List<KeyValuePair<HardwareMonitoramento, bool>> ValidarAlteracoes(HardwareMonitoramento hardware, HardwareMonitoramento hardwareCadastrado);
    }
}
