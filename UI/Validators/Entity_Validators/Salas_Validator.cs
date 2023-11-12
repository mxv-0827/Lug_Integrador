using BE;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Validators.Entity_Validators
{
    internal class Salas_Validator : AbstractValidator<Salas>
    {
        public Salas_Validator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("debe tener un texto asignado.");

            RuleFor(x => x.CapacidadTotal).NotEqual(0).WithMessage("no puede ser '0'.");
        }
    }
}
