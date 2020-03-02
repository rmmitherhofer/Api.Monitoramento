using System;
using Api.Monitoramento.Domain.DTO;
using Api.Monitoramento.Domain.Models;

namespace Api.Monitoramento.Domain.Mapper
{
    public class HardwareMonitoramentoMapper
    {
        public static HardwareMonitoramento ToHardwareMonitoramento(HardwareMonitoramentoApi hardwareMonitoramentoApi)
            => new HardwareMonitoramento
            {
                HostName = hardwareMonitoramentoApi.Computer_Name,
                NomeDepartamento = hardwareMonitoramentoApi.Department_Name,
                SistemaOperacional = hardwareMonitoramentoApi.SO_String,
                Fabricante = hardwareMonitoramentoApi.System_Manufacturer,
                TipoProduto = hardwareMonitoramentoApi.Computer_Type,
                EnderecoIP = hardwareMonitoramentoApi.Machine_Net_IPAddress,
                AnoLancamentoBIOS = DateTime.Parse(hardwareMonitoramentoApi.Bios_Release_Date.Trim()),
                IPDominio = hardwareMonitoramentoApi.Machine_IPDomain,
                MaquinaVirtual = hardwareMonitoramentoApi.Is_Virtual_Machine == "1" ? true : false,
                NomeProduto = hardwareMonitoramentoApi.System_Product_Name,
                NumeroDeSerie = hardwareMonitoramentoApi.System_Serial_Number,
                IDMaquina = hardwareMonitoramentoApi.Machine_ID,
                BitsSistemaOperacional = hardwareMonitoramentoApi.OS_Bits,
                Login = hardwareMonitoramentoApi.Login_Name,
                IdentidadeCPU = hardwareMonitoramentoApi.CPU_Identity,
                GeracaoCPU = hardwareMonitoramentoApi.CPU_Generation,
                TipoCPU = hardwareMonitoramentoApi.CPU_Type,
                ClockCPU = hardwareMonitoramentoApi.CPU_Clock,
                NumeroDeCores = int.Parse(hardwareMonitoramentoApi.Core_Num),
                QuantidadeCPUFisica = int.Parse(hardwareMonitoramentoApi.Physical_CPU_Amount),
                CPULogica = int.Parse(hardwareMonitoramentoApi.Logical_CPU),
                AlcanceDeMemoria = hardwareMonitoramentoApi.Memory_Range,
                DiscoTotal = hardwareMonitoramentoApi.Disk_Total,
                DiscoEmUso = hardwareMonitoramentoApi.Disk_Used,
                UsuarioPrincipal = hardwareMonitoramentoApi.Top_User,
                PorcentagemDeUsuariosPrincipais = hardwareMonitoramentoApi.Percent_Top_User,
                ServidoresDNS = hardwareMonitoramentoApi.DNS_Servers,
                Gateway = hardwareMonitoramentoApi.Machine_Gateway,
                DataDaColeta = DateTime.Parse(hardwareMonitoramentoApi.Collect_Date),
                DataDeAtualizacao = DateTime.Parse(hardwareMonitoramentoApi.Update_Date),
                UltimoLogin = hardwareMonitoramentoApi.Last_Login,
                Atualizado = false
            };
    }
}
