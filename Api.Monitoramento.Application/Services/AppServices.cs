using Api.Monitoramento.Infra.Data.UoW;

namespace Api.Monitoramento.Application.Services
{
    public abstract class AppServices
    {
        private readonly IUnitOfWork _uow;

        public AppServices(IUnitOfWork uow)
        {
            _uow = uow;
        }

        protected void Commit()
        {
            _uow.Commit();
        }
    }
}
