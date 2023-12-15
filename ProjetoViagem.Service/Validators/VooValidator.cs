using FluentValidation;
using ProjetoViagem.Domain.Entities;

namespace ProjetoViagem.Service.Validators
{
    public class VooValidator : AbstractValidator<Voo>
    {
        public VooValidator()
        {
            RuleFor(c => c.Origem)
               .NotEmpty().WithMessage("Por favor informe a origem.")
               .NotNull().WithMessage("Por favor informe a origem.");
            RuleFor(c => c.Destino)
               .NotEmpty().WithMessage("Por favor informe o destino.")
               .NotNull().WithMessage("Por favor informe o destino.");
            RuleFor(c => c.Data_voo)
               .NotEmpty().WithMessage("Por favor informe a Data de ida.")
               .NotNull().WithMessage("Por favor informe a Data de ida.");
            RuleFor(c => c.Horario_saida)
               .NotEmpty().WithMessage("Por favor informe o Horário de saída.")
               .NotNull().WithMessage("Por favor informe o Horário de saída.");
            RuleFor(c => c.Horario_chegada)
               .NotEmpty().WithMessage("Por favor informe o Horário de chegada.")
               .NotNull().WithMessage("Por favor informe o Horário de chegada.");
            RuleFor(c => c.Empresa)
                .NotEmpty().WithMessage("Por favor informe o nome da empresa.")
                .NotNull().WithMessage("Por favor informe o nome da empresa.");
        }
    }
}