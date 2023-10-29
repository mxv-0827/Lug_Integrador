using BE;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Validators
{
    internal class Usuario_Logueo_Validator : AbstractValidator<Usuario_Logueo>
    {
        public Usuario_Logueo_Validator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("no puede estar vacio.");
            RuleFor(x => x.Email).Matches("^[\\w\\.-]+@[\\w\\.-]+\\.\\w+$").WithMessage("no contiene el formato correcto.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("No puede estar vacio.");
            RuleFor(x => x.Password).Matches("^(?=.*[A-Z])(?=.*\\d).{6,}$").WithMessage("debe de tener al menos 6 caracteres, de los cuales uno debe ser una mayuscula y otra un numero.");
        }
    }
}
