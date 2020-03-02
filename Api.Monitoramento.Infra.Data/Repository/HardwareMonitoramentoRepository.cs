
using Microsoft.EntityFrameworkCore;
using Api.Monitoramento.Domain.Interface.Repository;
using Api.Monitoramento.Domain.Models;
using Api.Monitoramento.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Monitoramento.Infra.Data.Repository
{
    public class HardwareMonitoramentoRepository : RepositorioBaseEF<HardwareMonitoramento>, IHardwareMonitoramentoRepository
    {
        private readonly IRepository<HardwareMonitoramento> _repository;

        public HardwareMonitoramentoRepository(IRepository<HardwareMonitoramento> repository,
            MonitoramentoContext context) : base(context)
        {
            _repository = repository;
        }

        public HardwareMonitoramento ObterHardwareMonitorado(string NumeroDeSerie)
            => _repository.All
                .Where(h => h.NumeroDeSerie == NumeroDeSerie)
                .FirstOrDefault();

        public void AlterarHardware(HardwareMonitoramento value)
        {

        }
    }
}
