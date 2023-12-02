using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Base_BLL
    {
        private readonly Base_Mapper mapper = new Base_Mapper();
        

        public virtual void AsignarID(object entidad) => mapper.AsignarID(entidad);

        public virtual int AgregarEntidad(object entidad)
        {
            string spNombre = ObtenerNombreSP("Agregar", entidad.GetType().Name); //Devuelve 'AgregarUsuario', 'AgregarProducto', ...
            return mapper.Agregar(entidad, spNombre);
        }

        public virtual int ModificarEntidad(object entidad)
        {
            string spNombre = ObtenerNombreSP("Modificar", entidad.GetType().Name); //Devuelve 'ModificarUsuario', 'ModificarProducto', ...
            return mapper.Modificar(entidad, spNombre);
        }

        public virtual int EliminarEntidad(string nombreEntidad, int id)
        {
            string spNombre = ObtenerNombreSP("Eliminar", nombreEntidad); //Devuelve 'EliminarUsuario', 'EliminarProducto', ....
            return mapper.Eliminar(id, spNombre);
        }

        public DataTable ObtenerEntidadPorId(string nombreEntidad, dynamic id)
        {
            return mapper.ObtenerUnoPorId(id, "ObtenerRegistroPorId", nombreEntidad);
        }

        public DataTable ObtenerTodasEntidades(string nombreEntidad)
        {
            return mapper.ObtenerTodos("ObtenerTotalidadRegistros", nombreEntidad);
        }


        //Metodo que devuelve el nombre del SP segun lo que hace y su entidad.
        //Esto requiere nombrar correctamente a los SP en la BD y mantener una misma estructura para todos los nombre de esas operaciones.
        private string ObtenerNombreSP(string operacion, string entidad) => $"{operacion}{entidad}";
    }
}
