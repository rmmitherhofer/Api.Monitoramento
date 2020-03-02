using System;
using System.Collections.Generic;
using System.Text;
using Api.Monitoramento.Infra.Data.Context;

namespace Api.Monitoramento.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MonitoramentoContext _monitoramentoContext;

        public UnitOfWork(MonitoramentoContext monitoramentoContext)
        {
            _monitoramentoContext = monitoramentoContext;
        }

        public void Commit()
        {
            _monitoramentoContext.SaveChanges();
        }
    }
}
