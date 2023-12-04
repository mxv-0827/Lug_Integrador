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


        //-------------------------------------------------------ALTA BAJA Y MODIFICACION---------------------------------------------------

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

        //----------------------------------------------------------SOLO LECTURA------------------------------------------------------------

        public DataTable ObtenerEntidadPorId(string nombreEntidad, dynamic id) => mapper.ObtenerUnoPorId(id, "ObtenerRegistroPorId", nombreEntidad);

        public DataTable ObtenerTodasEntidades(string nombreEntidad) => mapper.ObtenerTodos("ObtenerTotalidadRegistros", nombreEntidad);

        protected T EjecutarConsultaEspecifica<T>(string sp, object parametros = null) => mapper.EjecutarConsultaEspecifica<T>(sp, parametros);

        //----------------------------------------------------AUXILIARES--------------------------------------------------------------------

        private string ObtenerNombreSP(string operacion, string entidad) => $"{operacion}{entidad}";

    }
}
