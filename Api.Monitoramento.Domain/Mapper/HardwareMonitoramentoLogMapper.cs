using Api.Monitoramento.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Monitoramento.Domain.Mapper
{
    class HardwareMonitoramentoLogMapper
    {
        public static HardwareMonitoramentoLog ToHarwareMonitoramentoLog(HardwareMonitoramento hardwareMonitoramento, string operacao)
            => new HardwareMonitoramentoLog
            {
                HostName = hardwareMonitoramento.HostName,
                HardwareMonitoramento = hardwareMonitoramento,
                NomeDepartamento = hardwareMonitoramento.NomeDepartamento,
                SistemaOperacional = hardwareMonitoramento.SistemaOperacional,
                Fabricante = hardwareMonitoramento.Fabricante,
                TipoProduto = hardwareMonitoramento.TipoProduto,
                EnderecoIP = hardwareMonitoramento.EnderecoIP,
                AnoLancamentoBIOS = hardwareMonitoramento.AnoLancamentoBIOS,
                IPDominio = hardwareMonitoramento.IPDominio,
                MaquinaVirtual = hardwareMonitoramento.MaquinaVirtual,
                NomeProduto = hardwareMonitoramento.NomeProduto,
                NumeroDeSerie = hardwareMonitoramento.NumeroDeSerie,
                IDMaquina = hardwareMonitoramento.IDMaquina,
                BitsSistemaOperacional = hardwareMonitoramento.BitsSistemaOperacional,
                Login = hardwareMonitoramento.Login,
                IdentidadeCPU = hardwareMonitoramento.IdentidadeCPU,
                GeracaoCPU = hardwareMonitoramento.GeracaoCPU,
                TipoCPU = hardwareMonitoramento.TipoCPU,
                ClockCPU = hardwareMonitoramento.ClockCPU,
                NumeroDeCores = hardwareMonitoramento.NumeroDeCores,
                QuantidadeCPUFisica = hardwareMonitoramento.QuantidadeCPUFisica,
                CPULogica = hardwareMonitoramento.CPULogica,
                AlcanceDeMemoria = hardwareMonitoramento.AlcanceDeMemoria,
                DiscoTotal = hardwareMonitoramento.DiscoTotal,
                DiscoEmUso = hardwareMonitoramento.DiscoEmUso,
                UsuarioPrincipal = hardwareMonitoramento.UsuarioPrincipal,
                PorcentagemDeUsuariosPrincipais = hardwareMonitoramento.PorcentagemDeUsuariosPrincipais,
                ServidoresDNS = hardwareMonitoramento.ServidoresDNS,
                Gateway = hardwareMonitoramento.Gateway,
                DataDaColeta = hardwareMonitoramento.DataDaColeta,
                DataDeAtualizacao = hardwareMonitoramento.DataDeAtualizacao,
                UltimoLogin = hardwareMonitoramento.UltimoLogin,
                Atualizado = hardwareMonitoramento.Atualizado,
                Operacao = operacao,                
                DataCriacao = operacao == "I" ? DateTime.Now : (DateTime?)null,
                DataDeAlteracao = DateTime.Now,
                DataRegistro = DateTime.Now
            };
    }
}
