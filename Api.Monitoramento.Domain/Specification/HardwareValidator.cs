using FluentValidation;
using Api.Monitoramento.Domain.Models;

namespace Api.Monitoramento.Domain.Specification
{
    class HardwareValidator : AbstractValidator<HardwareMonitoramento> 
    {
        public HardwareValidator()
        {
            RuleFor(h => h.HostName).NotEmpty().MaximumLength(60);
            RuleFor(h => h.NomeDepartamento).NotEmpty().WithMessage("Departamento é Obrigatório").MaximumLength(120);
            RuleFor(h => h.SistemaOperacional).MaximumLength(80);
            RuleFor(h => h.Fabricante).MaximumLength(200);
            RuleFor(h => h.TipoProduto).MaximumLength(120);
            RuleFor(h => h.EnderecoIP).MaximumLength(16);
            RuleFor(h => h.IPDominio).MaximumLength(150);
            RuleFor(h => h.NomeProduto).MaximumLength(160);
            RuleFor(h => h.NumeroDeSerie).MaximumLength(60);
            RuleFor(h => h.IDMaquina).MaximumLength(200);
            RuleFor(h => h.BitsSistemaOperacional).MaximumLength(15);
            RuleFor(h => h.Login).MaximumLength(45);
            RuleFor(h => h.IdentidadeCPU).MaximumLength(50);
            RuleFor(h => h.GeracaoCPU).MaximumLength(160);
            RuleFor(h => h.TipoCPU).MaximumLength(160);
            RuleFor(h => h.ClockCPU).MaximumLength(12);
            RuleFor(h => h.AlcanceDeMemoria).MaximumLength(12);
            RuleFor(h => h.DiscoTotal).MaximumLength(12);
            RuleFor(h => h.DiscoEmUso).MaximumLength(12);
            RuleFor(h => h.UsuarioPrincipal).MaximumLength(45);
            RuleFor(h => h.PorcentagemDeUsuariosPrincipais).MaximumLength(150);
            RuleFor(h => h.ServidoresDNS).MaximumLength(250);
            RuleFor(h => h.Gateway).MaximumLength(16);
            RuleFor(h => h.UltimoLogin).MaximumLength(45);
        }
    }
}
