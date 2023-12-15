using FluentValidation;
using ProjetoViagem.Domain.Entities;

namespace ProjetoViagem.Service.Validators
{
    public class ViagemValidator : AbstractValidator<Viagem>
    {
        public ViagemValidator()
        {
            RuleFor(c => c.Origem)
               .NotEmpty().WithMessage("Por favor informe a origem.")
               .NotNull().WithMessage("Por favor informe a origem.");
            RuleFor(c => c.Destino)
               .NotEmpty().WithMessage("Por favor informe o destino.")
               .NotNull().WithMessage("Por favor informe o destino.");
            RuleFor(c => c.Data_inicio)
               .NotEmpty().WithMessage("Por favor informe a Data de ida.")
               .NotNull().WithMessage("Por favor informe a Data de ida.");
        }
    }
}
