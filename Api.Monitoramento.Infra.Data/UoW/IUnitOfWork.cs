using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Monitoramento.Infra.Data.UoW
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
