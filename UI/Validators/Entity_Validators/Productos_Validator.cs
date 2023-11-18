using BE;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Validators.Entity_Validators
{
    internal class Productos_Validator : AbstractValidator<Productos>
    {
        public Productos_Validator() 
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("debe de contener un valor.");

            RuleFor(x => x.Precio).NotEqual(0).WithMessage("del producto no puede ser '0'.");
            RuleFor(x => x.Precio).NotNull().WithMessage("del producto debe de contener un valor.");

            RuleFor(x => x.Dimension).NotEmpty().WithMessage("debe de contener un valor.");

            RuleFor(x => x.Imagen).NotEmpty().WithMessage("debe de contener una imagen a guardar.");
        }
    }
}
