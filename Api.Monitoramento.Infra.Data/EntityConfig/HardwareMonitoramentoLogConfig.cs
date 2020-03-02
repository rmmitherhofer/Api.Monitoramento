using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Api.Monitoramento.Domain.Models;

namespace Api.Monitoramento.Infra.Data.EntityConfig
{
    internal class HardwareMonitoramentoLogConfig : IEntityTypeConfiguration<HardwareMonitoramentoLog>
    {
        public void Configure(EntityTypeBuilder<HardwareMonitoramentoLog> builder)
        {
            builder.Property(h => h.Id).HasColumnType("INT").IsRequired();
            builder.Property(h => h.HostName).HasColumnType("VARCHAR(60)").IsRequired();
            builder.Property(h => h.NomeDepartamento).HasColumnType("VARCHAR(120)");
            builder.Property(h => h.SistemaOperacional).HasColumnType("VARCHAR(80)");
            builder.Property(h => h.Fabricante).HasColumnType("VARCHAR(200)").IsRequired();
            builder.Property(h => h.TipoProduto).HasColumnType("VARCHAR(120)").IsRequired();
            builder.Property(h => h.EnderecoIP).HasColumnType("VARCHAR(16)");
            builder.Property(h => h.AnoLancamentoBIOS).HasColumnType("DATETIME");
            builder.Property(h => h.IPDominio).HasColumnType("VARCHAR(150)");
            builder.Property(h => h.MaquinaVirtual).HasColumnType("BIT");
            builder.Property(h => h.NomeProduto).HasColumnType("VARCHAR(160)").IsRequired();
            builder.Property(h => h.NumeroDeSerie).HasColumnType("VARCHAR(60)").IsRequired();
            builder.Property(h => h.IDMaquina).HasColumnType("VARCHAR(200)").IsRequired();
            builder.Property(h => h.BitsSistemaOperacional).HasColumnType("VARCHAR(15)");
            builder.Property(h => h.Login).HasColumnType("VARCHAR(45)");
            builder.Property(h => h.IdentidadeCPU).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(h => h.GeracaoCPU).HasColumnType("VARCHAR(160)");
            builder.Property(h => h.TipoCPU).HasColumnType("VARCHAR(160)").IsRequired();
            builder.Property(h => h.ClockCPU).HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(h => h.NumeroDeCores).HasColumnType("INT");
            builder.Property(h => h.QuantidadeCPUFisica).HasColumnType("INT");
            builder.Property(h => h.CPULogica).HasColumnType("INT");
            builder.Property(h => h.AlcanceDeMemoria).HasColumnType("VARCHAR(12)");
            builder.Property(h => h.DiscoTotal).HasColumnType("VARCHAR(12)");
            builder.Property(h => h.DiscoEmUso).HasColumnType("VARCHAR(12)");
            builder.Property(h => h.UsuarioPrincipal).HasColumnType("VARCHAR(45)");
            builder.Property(h => h.PorcentagemDeUsuariosPrincipais).HasColumnType("VARCHAR(10)");
            builder.Property(h => h.ServidoresDNS).HasColumnType("VARCHAR(250)");
            builder.Property(h => h.Gateway).HasColumnType("VARCHAR(16)");
            builder.Property(h => h.DataDaColeta).HasColumnType("DATETIME").IsRequired();
            builder.Property(h => h.DataDeAtualizacao).HasColumnType("DATE").IsRequired();
            builder.Property(h => h.UltimoLogin).HasColumnType("VARCHAR(45)");
            builder.Property(h => h.Operacao).HasColumnType("CHAR(1)");
            builder.Property(h => h.DataCriacao).HasColumnType("DATETIME");
            builder.Property(h => h.DataDeAlteracao).HasColumnType("DATETIME");
            builder.Property(h => h.DataRegistro).HasColumnType("DATETIME");

        }
    }
}
