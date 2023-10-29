using BE;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Validators.Entity_Validators
{
    internal class Credenciales_Validator : AbstractValidator<Credenciales>
    {
        public Credenciales_Validator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("no puede estar vacio.");
            RuleFor(x => x.Email).Matches("^[\\w\\.-]+@[\\w\\.-]+\\.\\w+$").WithMessage("no contiene el formato correcto.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("no puede estar vacio.").OverridePropertyName("Contraseña");
            RuleFor(x => x.Password).Matches("^(?=.*[A-Z])(?=.*\\d).{6,}$").WithMessage("debe de tener al menos 6 caracteres, de los cuales uno debe ser una mayuscula y otra un numero.").OverridePropertyName("Contraseña");
        }
    }
}
