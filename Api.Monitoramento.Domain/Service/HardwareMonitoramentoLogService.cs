using Api.Monitoramento.Domain.Interface.Repository;
using Api.Monitoramento.Domain.Interface.Service;
using Api.Monitoramento.Domain.Mapper;
using Api.Monitoramento.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Monitoramento.Domain.Service
{
    public class HardwareMonitoramentoLogService : IHardwareMonitoramentoLogService
    {
        private readonly IHardwareMonitoramentoLogRepository _hardwareMonitoramentoLogRepository;
        private readonly IRepository<HardwareMonitoramentoLog> _repositoryHardwareLog;

        public HardwareMonitoramentoLogService(
           IHardwareMonitoramentoLogRepository hardwareMonitoramentoLogRepository,
           IRepository<HardwareMonitoramentoLog> repositoryHardwareLog)
        {
            _hardwareMonitoramentoLogRepository = hardwareMonitoramentoLogRepository;
            _repositoryHardwareLog = repositoryHardwareLog;
        }
        public void Incluir(HardwareMonitoramento hardwareMonitoramento, string tipoOperacao)
        {
            var logHardware = HardwareMonitoramentoLogMapper.ToHarwareMonitoramentoLog(hardwareMonitoramento, tipoOperacao);
            _repositoryHardwareLog.Incluir(logHardware);

        }
    }
}
