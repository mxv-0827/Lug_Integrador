using BE;
using FluentValidation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Validators.Entity_Validators
{
    internal class HorarioPeliculas_Validator : AbstractValidator<HorarioPeliculas>
    {
        public HorarioPeliculas_Validator()
        {
            RuleFor(x => x.IDSala).NotEqual(0).WithMessage("no puede estar vacio.");

            RuleFor(x => x.IDPelicula).NotEqual(0).WithMessage("no puede estar vacio.");

            RuleFor(x => x.Fecha).NotEqual(new DateTime(1111, 11, 11)).WithMessage("no puede estar vacia y ademas requiere de un formato valido.");
            RuleFor(x => x.Fecha).GreaterThan(DateTime.Today).WithMessage("requiere de una fecha superior a la actual.");

            RuleFor(x => x.HoraInicio).NotEqual(new TimeSpan(0, 0, 0)).WithMessage("requiere de tener un horario asignado.");

            RuleFor(x => x.PrecioEntrada).NotEqual(0).WithMessage("no puede ser 0");
        }
    }
}
