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
    public class Base_BLL<T> where T : class //Metodos que usan todas las entidades.
    {
        protected readonly Base_Mapper<T> mapper = new Base_Mapper<T>();
        
        public virtual void AsignarID(T entity) => mapper.AsignarID(entity);

        public virtual int AgregarEntidad(T entity)
        {
            string spNombre = ObtenerNombreSP("Agregar", entity.GetType().Name); //Devuelve 'AgregarUsuario', 'AgregarProducto', ...
            return mapper.Agregar(entity, spNombre);
        }

        public virtual int ModificarEntidad(T entity)
        {
            string spNombre = ObtenerNombreSP("Modificar", entity.GetType().Name); //Devuelve 'ModificarUsuario', 'ModificarProducto', ...
            return mapper.Modificar(entity, spNombre);
        }

        public virtual int EliminarEntidad(string nombreEntidad, int id)
        {
            string spNombre = ObtenerNombreSP("Eliminar", nombreEntidad); //Devuelve 'EliminarUsuario', 'EliminarProducto', ....
            return mapper.Eliminar(id, spNombre);
        }

        public DataTable ObtenerEntidadPorId(string nombreEntidad, int id)
        {
            return mapper.ObtenerUnoPorId(id, "ObtenerRegistroPorId", nombreEntidad);
        }

        public DataTable ObtenerTodasEntidades(string nombreEntidad)
        {
            return mapper.ObtenerTodos("ObtenerTotalidadRegistros", nombreEntidad);
        }


        //Metodo que devuelve el nombre del SP segun lo que hace y su entidad.
        //Esto requiere nombrar correctamente a los SP en la BD y mantener una misma estructura para todos los nombre de esas operaciones.
        protected string ObtenerNombreSP(string operacion, string entidad) => $"{operacion}{entidad}";
    }
}
