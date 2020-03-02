using Api.Monitoramento.Domain.Interface.Repository;
using Api.Monitoramento.Domain.Interface.Service;
using Api.Monitoramento.Domain.Models;
using System;
using System.Collections.Generic;

namespace Api.Monitoramento.Domain.Service
{
    public class HardwareMonitoramentoService : IHardwareMonitoramentoService
    {

        private readonly IHardwareMonitoramentoRepository _hardwareMonitoramentoRepository;
        private readonly IRepository<HardwareMonitoramento> _repositoryHardware;

        public HardwareMonitoramentoService(
            IHardwareMonitoramentoRepository hardwareMonitoramentoRepository,
            IRepository<HardwareMonitoramento> repositoryHardware)
        {
            _hardwareMonitoramentoRepository = hardwareMonitoramentoRepository;
            _repositoryHardware = repositoryHardware;
        }
        public HardwareMonitoramento ValidarHardwareMonitorado(string numeroSerie)
            => VerificarHardwareMonitorado(numeroSerie);

        private HardwareMonitoramento VerificarHardwareMonitorado(string numeroSerie)
            => _hardwareMonitoramentoRepository.ObterHardwareMonitorado(numeroSerie);

        public List<KeyValuePair<HardwareMonitoramento, bool>> ValidarAlteracoes(HardwareMonitoramento hardware, HardwareMonitoramento hardwareCadastrado)
        {
            List<KeyValuePair<HardwareMonitoramento, bool>> validacoes = new List<KeyValuePair<HardwareMonitoramento, bool>>();
            validacoes.Add(ValidarCamposExpecificos(hardware, hardwareCadastrado));
            validacoes.Add(ValidarObjeto(hardware, hardwareCadastrado));
            return validacoes;
        }

        private KeyValuePair<HardwareMonitoramento, bool> ValidarObjeto(HardwareMonitoramento hardware, HardwareMonitoramento hardwareCadastrado)
        {
            if (hardware.HostName == hardwareCadastrado.HostName &&
                hardware.NomeDepartamento == hardwareCadastrado.NomeDepartamento &&
                hardware.SistemaOperacional == hardwareCadastrado.SistemaOperacional &&
                hardware.Fabricante == hardwareCadastrado.Fabricante &&
                hardware.TipoProduto == hardwareCadastrado.TipoProduto &&
                hardware.EnderecoIP == hardwareCadastrado.EnderecoIP &&
                hardware.AnoLancamentoBIOS == hardwareCadastrado.AnoLancamentoBIOS &&
                hardware.IPDominio == hardwareCadastrado.IPDominio &&
                hardware.NomeProduto == hardwareCadastrado.NomeProduto &&
                hardware.NumeroDeSerie == hardwareCadastrado.NumeroDeSerie &&
                hardware.IDMaquina == hardwareCadastrado.IDMaquina &&
                hardware.BitsSistemaOperacional == hardwareCadastrado.BitsSistemaOperacional &&
                hardware.Login == hardwareCadastrado.Login &&
                hardware.IdentidadeCPU == hardwareCadastrado.IdentidadeCPU &&
                hardware.GeracaoCPU == hardwareCadastrado.GeracaoCPU &&
                hardware.TipoCPU == hardwareCadastrado.TipoCPU &&
                hardware.ClockCPU == hardwareCadastrado.ClockCPU &&
                hardware.NumeroDeCores == hardwareCadastrado.NumeroDeCores &&
                hardware.QuantidadeCPUFisica == hardwareCadastrado.QuantidadeCPUFisica &&
                hardware.CPULogica == hardwareCadastrado.CPULogica &&
                hardware.AlcanceDeMemoria == hardwareCadastrado.AlcanceDeMemoria &&
                hardware.UsuarioPrincipal == hardwareCadastrado.UsuarioPrincipal &&
                hardware.ServidoresDNS == hardwareCadastrado.ServidoresDNS &&
                hardware.Gateway == hardwareCadastrado.Gateway
                )
            {
                return new KeyValuePair<HardwareMonitoramento, bool>(hardwareCadastrado, false);
            }
            else
            {
                hardwareCadastrado.HostName = hardware.HostName;
                hardwareCadastrado.NomeDepartamento = hardware.NomeDepartamento;
                hardwareCadastrado.SistemaOperacional = hardware.SistemaOperacional;
                hardwareCadastrado.Fabricante = hardware.Fabricante;
                hardwareCadastrado.TipoProduto = hardware.TipoProduto;
                hardwareCadastrado.EnderecoIP = hardware.EnderecoIP;
                hardwareCadastrado.AnoLancamentoBIOS = hardware.AnoLancamentoBIOS;
                hardwareCadastrado.IPDominio = hardware.IPDominio;
                hardwareCadastrado.NomeProduto = hardware.NomeProduto;
                hardwareCadastrado.MaquinaVirtual = hardware.MaquinaVirtual;
                hardwareCadastrado.NumeroDeSerie = hardware.NumeroDeSerie;
                hardwareCadastrado.IDMaquina = hardware.IDMaquina;
                hardwareCadastrado.BitsSistemaOperacional = hardware.BitsSistemaOperacional;
                hardwareCadastrado.Login = hardware.Login;
                hardwareCadastrado.IdentidadeCPU = hardware.IdentidadeCPU;
                hardwareCadastrado.GeracaoCPU = hardware.GeracaoCPU;
                hardwareCadastrado.TipoCPU = hardware.TipoCPU;
                hardwareCadastrado.ClockCPU = hardware.ClockCPU;
                hardwareCadastrado.NumeroDeCores = hardware.NumeroDeCores;
                hardwareCadastrado.QuantidadeCPUFisica = hardware.QuantidadeCPUFisica;
                hardwareCadastrado.CPULogica = hardware.CPULogica;
                hardwareCadastrado.AlcanceDeMemoria = hardware.AlcanceDeMemoria;
                hardwareCadastrado.DiscoTotal = hardware.DiscoTotal;
                hardwareCadastrado.DiscoEmUso = hardware.DiscoEmUso;
                hardwareCadastrado.UsuarioPrincipal = hardware.UsuarioPrincipal;
                hardwareCadastrado.PorcentagemDeUsuariosPrincipais = hardware.PorcentagemDeUsuariosPrincipais;
                hardwareCadastrado.ServidoresDNS = hardware.ServidoresDNS;
                hardwareCadastrado.Gateway = hardware.Gateway;
                hardwareCadastrado.DataDaColeta = hardware.DataDaColeta;
                hardwareCadastrado.DataDeAtualizacao = hardware.DataDeAtualizacao;
                hardwareCadastrado.UltimoLogin = hardwareCadastrado.UltimoLogin;
                return new KeyValuePair<HardwareMonitoramento, bool>(hardwareCadastrado, true);
            }

        }

        private KeyValuePair<HardwareMonitoramento, bool> ValidarCamposExpecificos(HardwareMonitoramento hardware, HardwareMonitoramento hardwareCadastrado)
        {
            if (hardware.IDMaquina == hardwareCadastrado.IDMaquina &&
                hardware.NomeDepartamento == hardwareCadastrado.NomeDepartamento
                )
                return new KeyValuePair<HardwareMonitoramento, bool>(hardwareCadastrado, false);
            return new KeyValuePair<HardwareMonitoramento, bool>(hardwareCadastrado, true);
        }

        public void Incluir(HardwareMonitoramento hardwareMonitoramento)
        {
            if (hardwareMonitoramento.IsValid())
                _repositoryHardware.Incluir(hardwareMonitoramento);
            else
                foreach (var erro in hardwareMonitoramento.ValidationResult.Errors)
                    Console.WriteLine(erro.ErrorMessage);
        }

        public void Alterar(HardwareMonitoramento hardwareMonitoramento, bool atualizado)
        {
            hardwareMonitoramento.Atualizado = atualizado;
            if (hardwareMonitoramento.IsValid())
                _repositoryHardware.Alterar(hardwareMonitoramento);
            else
                foreach (var erro in hardwareMonitoramento.ValidationResult.Errors)
                    Console.WriteLine(erro.ErrorMessage);
        }

    }
}
