using FluentValidation;
using FluentValidation.Results;
using Api.Monitoramento.Domain.Specification;
using System;

namespace Api.Monitoramento.Domain.Models
{
    public class HardwareMonitoramento : AbstractValidator<HardwareMonitoramento>
    {
        public Guid Id { get; set; }
        public string HostName { get; set; }
        public string NomeDepartamento { get; set; }
        public string SistemaOperacional { get; set; }
        public string Fabricante { get; set; }
        public string TipoProduto { get; set; }
        public string EnderecoIP { get; set; }
        public DateTime AnoLancamentoBIOS { get; set; }
        public string IPDominio { get; set; }
        public bool MaquinaVirtual { get; set; }
        public string NomeProduto { get; set; }
        public string NumeroDeSerie { get; set; }
        public string IDMaquina { get; set; }
        public string BitsSistemaOperacional { get; set; }
        public string Login { get; set; }
        public string IdentidadeCPU { get; set; }
        public string GeracaoCPU { get; set; }
        public string TipoCPU { get; set; }
        public string ClockCPU { get; set; }
        public int NumeroDeCores { get; set; }
        public int QuantidadeCPUFisica { get; set; }
        public int CPULogica { get; set; }
        public string AlcanceDeMemoria { get; set; }
        public string DiscoTotal { get; set; }
        public string DiscoEmUso { get; set; }
        public string UsuarioPrincipal { get; set; }
        public string PorcentagemDeUsuariosPrincipais { get; set; }
        public string ServidoresDNS { get; set; }
        public string Gateway { get; set; }
        public DateTime DataDaColeta { get; set; }
        public DateTime DataDeAtualizacao { get; set; }
        public string UltimoLogin { get; set; }
        public bool Atualizado { get; set; }        
        public ValidationResult ValidationResult { get; protected set; }
        public HardwareMonitoramento()
        {
            ValidationResult = new ValidationResult();
            Id = Guid.NewGuid();
        }
        public bool IsValid()
        {
            HardwareValidator validator = new HardwareValidator();
            ValidationResult = validator.Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
