using BE;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Validators.Entity_Validators
{
    internal class Peliculas_Validator : AbstractValidator<Peliculas>
    {
        public Peliculas_Validator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("no puede estar vacio.");

            RuleFor(x => x.Descripcion).NotEmpty().WithMessage("no puede estar vacio.");

            RuleFor(x => x.Estreno).NotEqual(new DateTime(1111, 11, 11)).WithMessage("no puede estar vacia y ademas requiere de un formato valido."); // 11/11/1111 = fecha por default en caso de estar vacia.
            RuleFor(x => x.Estreno).LessThanOrEqualTo(DateTime.Today).WithMessage("no puede ser mayor a la fecha actual.");

            RuleFor(x => x.Duracion).NotEqual(new TimeSpan(0, 0, 0)).WithMessage("no puede estar vacio."); // 0 segundos = tiempo por default en caso de estar vacia.
            RuleFor(x => x.Duracion).LessThan(new TimeSpan(4, 0, 0)).WithMessage("no puede ser superior a 4 horas.");

            RuleFor(x => x.Portada).NotEmpty().WithMessage("de la pelicula debe de contener una imagen.");

            RuleFor(x => x.Trailer).NotEmpty().WithMessage("requiere de un link para visualizarlo.");

            RuleFor(x => x.IDRestriccion).NotEqual(0).WithMessage("debe de tener asignado una restriccion.");
        }
    }
}
