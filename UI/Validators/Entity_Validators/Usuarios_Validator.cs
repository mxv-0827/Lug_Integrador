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

            RuleFor(x => x.DNI).NotEqual(00000000).WithMessage("no puede estar vacio.");
            RuleFor(x => x.DNI.ToString()).MaximumLength(8).WithMessage("debe contener 8 caracteres como maximo.").OverridePropertyName("DNI"); 
            RuleFor(x => x.DNI.ToString()).MinimumLength(8).WithMessage("debe contener 8 caracteres como minimo.").OverridePropertyName("DNI");

            RuleFor(x => x.Nombre).NotEmpty().WithMessage("no puede estar vacio.");

            RuleFor(x => x.Apellido).NotEmpty().WithMessage("no puede estar vacio.");

            RuleFor(x => x.Sexo).NotEmpty().WithMessage("no puede estar vacio.");

            RuleFor(x => x.Fecha_Nacimiento).NotEqual(new DateTime(1111, 11, 11)).WithMessage("no puede estar vacio y ademas requiere de un formato valido.");
            RuleFor(x => DateTime.Today.Year - x.Fecha_Nacimiento.Year).GreaterThanOrEqualTo(18).WithMessage("debe ser una fecha de nacimiento de un mayor de edad.").OverridePropertyName("Fecha_Nacimiento");

            RuleFor(x => x.IDMembresia).NotEqual(0).WithMessage("no puede estar vacio.");
        }
    }
}
