using Api.Monitoramento.Application.Interface;
using Api.Monitoramento.Application.Util;
using Api.Monitoramento.Domain.Interface.Service;
using Api.Monitoramento.Domain.Mapper;
using Api.Monitoramento.Domain.Models;
using Api.Monitoramento.Infra.Data.ServiceExternal;
using Api.Monitoramento.Infra.Data.UoW;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Monitoramento.Application.Services
{
    public class HardwareAppService : AppServices, IHardwareAppService
    {
        private readonly IHardwareMonitoramentoService _hardwareMonitoramentoService;
        private readonly IHardwareMonitoramentoLogService _hardwareMonitoramentoLogService;
        private readonly ISmartAutoMatosApi _smartAutoMatosApi;

        public HardwareAppService(
            IHardwareMonitoramentoService hardwareMonitoramentoService,
            IHardwareMonitoramentoLogService hardwareMonitoramentoLogService,
            ISmartAutoMatosApi smartAutoMatosApi,
            IUnitOfWork uow) : base(uow)
        {
            _hardwareMonitoramentoService = hardwareMonitoramentoService;
            _hardwareMonitoramentoLogService = hardwareMonitoramentoLogService;
            _smartAutoMatosApi = smartAutoMatosApi;
        }

        public async Task AdicionarCargaMonitoramento()
        {
            var hardwaresMonitoradosApi = await _smartAutoMatosApi.ChamarAPISmartAutoMatosAsync();
            foreach (var hardwareMonitorado in hardwaresMonitoradosApi)
            {
                var hardware = HardwareMonitoramentoMapper.ToHardwareMonitoramento(hardwareMonitorado);
                var hardwareCadastrado = _hardwareMonitoramentoService.ValidarHardwareMonitorado(hardware.NumeroDeSerie);

                if (hardwareCadastrado != null)
                    Alterar(hardware, hardwareCadastrado);
                else
                    Incluir(hardware);
            }
            Commit();
        }

        private void Incluir(HardwareMonitoramento hardware)
        {
            _hardwareMonitoramentoService.Incluir(hardware);
            if (hardware.ValidationResult.IsValid)
                IncluirLog(hardware, EnumHelper.GetEnumDescription(Enums.TipoOperacao.Inclusao));
        }

        private void Alterar(HardwareMonitoramento hardware, HardwareMonitoramento hardwareCadastrado)
        {
            var validacao = _hardwareMonitoramentoService.ValidarAlteracoes(hardware, hardwareCadastrado);

            if (validacao[0].Value)
                _hardwareMonitoramentoService.Alterar(validacao[0].Key, true);
            else
                _hardwareMonitoramentoService.Alterar(validacao[0].Key, false);

            if (validacao[1].Value)
                if (hardware.ValidationResult.IsValid)
                    IncluirLog(validacao[0].Key, EnumHelper.GetEnumDescription(Enums.TipoOperacao.Alteracao));
        }

        private void IncluirLog(HardwareMonitoramento hardwareMonitoramento, string tipoOperacao)
            => _hardwareMonitoramentoLogService.Incluir(hardwareMonitoramento, tipoOperacao);
    }
}
