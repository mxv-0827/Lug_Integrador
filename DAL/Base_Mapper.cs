using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public class Base_Mapper
    {
        private readonly BD_Conexion acceso = BD_Conexion.ObtenerInstancia();


        //------------------------------------------------------------ALTA BAJA Y MODIFICACION----------------------------------------------------

        public void AsignarID(object entidad)
        {
            SqlParameter[] sqlProp = new SqlParameter[] { new SqlParameter("@Tabla", entidad.GetType().Name) };

            int ID = (int)acceso.ObtenerDato("AsignarIDGeneral", sqlProp);
            entidad.GetType().GetProperty("ID").SetValue(entidad, ID);
        }

        public virtual int Agregar(object entidad, string sp) => acceso.Escribir(sp, GenerarSqlPropsArray(entidad));

        public virtual int Modificar(object entidad, string sp) => acceso.Escribir(sp, GenerarSqlPropsArray(entidad)); 
        
        public int Eliminar(int id, string storedProc) => acceso.Escribir(storedProc, new SqlParameter[] { new SqlParameter("Id", id)});

        //----------------------------------------------------------SOLO LECTURA------------------------------------------------------------------

        public DataTable ObtenerUnoPorId(dynamic id, string storedProc, string nombreEntidad) 
        {
            SqlParameter[] sqlProp = new SqlParameter[]
            { 
                new SqlParameter("@Tabla", nombreEntidad),
                new SqlParameter("@Id", id) 
            };

            return acceso.Leer(storedProc, sqlProp);
        }

        public DataTable ObtenerTodos(string storedProc, string nombreEntidad) => acceso.Leer(storedProc, new SqlParameter[] { new SqlParameter("@Tabla", nombreEntidad) });

        public T EjecutarConsultaEspecifica<T>(string sp, object parametros = null)
        {
            SqlParameter[] sqlProps = GenerarSqlPropsArray(parametros);

            if (typeof(T) == typeof(DataTable)) return (T)(object)acceso.Leer(sp, sqlProps);
            else return (T)acceso.ObtenerDato(sp, sqlProps);
        }

        //--------------------------------------------------------AUXILIARES----------------------------------------------------------------------

        private SqlParameter[] GenerarSqlPropsArray(object entidad)
        {
            PropertyInfo[] entityProps = entidad.GetType().GetProperties();
            List<SqlParameter> lstProps = new List<SqlParameter>();

            foreach (PropertyInfo prop in entityProps)
            {
                string nombre = prop.Name;
                object valor = prop.GetValue(entidad);

                SqlParameter sqlProp = new SqlParameter($"{nombre}", valor);
                lstProps.Add(sqlProp);
            }

            return lstProps.ToArray();
        }
    }
}
