using Microsoft.EntityFrameworkCore;
using Api.Monitoramento.Domain.Interface.Repository;
using Api.Monitoramento.Infra.Data.Context;
using System.Linq;

namespace Api.Monitoramento.Infra.Data.Repository
{
    public class RepositorioBaseEF<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly MonitoramentoContext _context;   

        public RepositorioBaseEF(MonitoramentoContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> All => _context.Set<TEntity>().AsQueryable();

        public void Alterar(params TEntity[] obj)
        {
            _context.Set<TEntity>().UpdateRange(obj);
            //_context.SaveChanges();
        }

        public void Excluir(params TEntity[] obj)
        {
            _context.Set<TEntity>().RemoveRange(obj);
        }

        public TEntity Find(int key)
        {
            return _context.Find<TEntity>(key);
        }

        public void Incluir(params TEntity[] obj)
        {
            _context.Set<TEntity>().AddRange(obj);
            //_context.SaveChanges();
        }
    }
}
