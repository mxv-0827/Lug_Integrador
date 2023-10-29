using BE;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Validators.Entity_Validators
{
    internal class Usuarios_Validator : AbstractValidator<Usuarios>
    {
        public Usuarios_Validator()
        {
            //Al 'DNI' hay q hacerlo string ya que sino no deja meter muchos metodos.
            //El resto de propiedades no incluidas se validan antes de ingresar aca.

            RuleFor(x => x.DNI).NotEmpty().WithMessage("no puede estar vacio.");
            RuleFor(x => x.DNI.ToString()).Matches(@"^\d+$").WithMessage("solo debe de contener numeros.").OverridePropertyName("DNI");
            RuleFor(x => x.DNI.ToString()).MaximumLength(8).WithMessage("debe contener 8 caracteres como maximo.").OverridePropertyName("DNI"); 
            RuleFor(x => x.DNI.ToString()).MinimumLength(8).WithMessage("debe contener 8 caracteres como minimo.").OverridePropertyName("DNI");

            RuleFor(x => x.Nombre).NotEmpty().WithMessage("no puede estar vacio.");
            RuleFor(x => x.Nombre).Matches("^[A-Za-z]+$").WithMessage("solo debe de contener letras.");

            RuleFor(x => x.Apellido).NotEmpty().WithMessage("no puede estar vacio.");
            RuleFor(x => x.Apellido).Matches("^[A-Za-z]+$").WithMessage("solo debe de contener letras.");

            RuleFor(x => x.Sexo).NotEmpty().WithMessage("no puede estar vacio.");
        }
    }
}
