using BE;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Validators.Entity_Validators
{
    internal class Cupones_Validator : AbstractValidator<Cupones>
    {
        public Cupones_Validator()
        {
            RuleFor(x => x.ID).NotEmpty().WithMessage("debe de contener un codigo valido.");

            RuleFor(x => x.IDDescuento).NotEqual(0).WithMessage("debe de estar asignado a un valor.");
        }
    }
}
