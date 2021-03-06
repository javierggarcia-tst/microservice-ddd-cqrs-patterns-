﻿using FluentValidation;
using ServicioPrueba.Application.Atributos.AddAtributos;

namespace ServicioLiquidacion.Application.Liquidacion.LiquidacionAgrupada.CrearLiquidacionAgrupada
{
    public class AtributosModifyCommandValidator : AbstractValidator<AtributosModifyCommand>
    {
        public AtributosModifyCommandValidator()
        {
            RuleFor(x => x.AtributoId).NotEmpty().WithMessage("Atributo ID is empty");
            RuleFor(x => x.Descripcion).NotEmpty().WithMessage("Descripcion is empty");
        }
    }
}
