using Api.Monitoramento.Domain.Interface.Repository;
using Api.Monitoramento.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Monitoramento.Infra.Data.Repository
{
    public class HardwareMonitoramentoLogRepository : IHardwareMonitoramentoLogRepository
    {
        private readonly IRepository<HardwareMonitoramentoLog> _repository;
        public HardwareMonitoramentoLogRepository(IRepository<HardwareMonitoramentoLog> repository)
        {
            _repository = repository;
        }
        public void Incluir(HardwareMonitoramento hardwareMonitoramento, string tipoOperacao)
        {
           
        }
    }
}
