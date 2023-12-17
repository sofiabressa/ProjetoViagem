﻿using FluentValidation;
using ProjetoViagem.Domain.Entities;

namespace ProjetoViagem.Service.Validators
{
    public class CidadeValidator : AbstractValidator<Cidade>
    {
        public CidadeValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("Por favor informe o estado.")
                .NotNull().WithMessage("Por favor informe o estado.");
        }
    }
}
