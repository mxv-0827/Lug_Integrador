using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Base_BLL<T> where T : class
    {
        Base_Mapper<T> mapper = new Base_Mapper<T>();

        public int AgregarEntidad(T entity)
        {
            string spNombre = ObtenerNombreSP("Agregar", entity.GetType().Name); //Devuelve 'AgregarUsuario', 'AgregarProducto', ...
            int linesAffected = mapper.Agregar(entity, spNombre);

            return linesAffected;
        }

        public int ModificarEntidad(T entity)
        {
            string spNombre = ObtenerNombreSP("Modificar", entity.GetType().Name); //Devuelve 'ModificarUsuario', 'ModificarProducto', ...
            int linesAffected = mapper.Modificar(entity, spNombre);

            return linesAffected;
        }

        public int EliminarEntidad(string nombreEntidad, int id)
        {
            string spNombre = ObtenerNombreSP("Eliminar", nombreEntidad); //Devuelve 'EliminarUsuario', 'EliminarProducto', ....
            int linesAffected = mapper.Eliminar(id, spNombre);

            return linesAffected;
        }


        //Metodo que devuelve el nombre del SP segun lo que hace y su entidad.
        //Esto requiere nombrar correctamente a los SP en la BD y mantener una misma estructura para todos los nombre de esas operaciones.
        private string ObtenerNombreSP(string operacion, string entidad) => $"{operacion}{entidad}";
    }
}
