using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Validators
{
    internal static class Generic_Validator<T> where T : class
    {
        public static void ValidarPropiedades(T entidad) 
        {
            string tipo = entidad.GetType().Name;
            Type tipoValidador = Type.GetType($"UI.Validators.Entity_Validators.{tipo}_Validator"); //Obtiene el tipo del validador usando como referencia el nombre del tipo de la entidad.

            object instanciaValidador = Activator.CreateInstance(tipoValidador);


            if(instanciaValidador is AbstractValidator<T> validador)
            {
                ValidationResult resultado = validador.Validate(entidad);

                string mensajeErrores = "";

                if (!resultado.IsValid)
                {
                    foreach(var errores in resultado.Errors)
                    {
                        mensajeErrores += $"El campo {errores.PropertyName.ToUpper()} {errores.ErrorMessage}\n\n";
                    }

                    throw new Exception(mensajeErrores);
                }
            }
        }
    }
}
