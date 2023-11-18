using BE;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Validators.Entity_Validators
{
    internal class Combos_Validator : AbstractValidator<Combos>
    {
        public Combos_Validator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("no puede estar vacio.");

            RuleFor(x => x.Descripcion).NotEmpty().WithMessage("no puede estar vacio.");

            RuleFor(x => x.Imagen).NotEmpty().WithMessage("del producto debe de contener una imagen.");

            RuleFor(x => x.IDMembresia).NotEqual(0).WithMessage("debe de tener una membresia de descuento.");
        }
    }
}
