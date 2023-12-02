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
        internal BD_Conexion acceso = BD_Conexion.ObtenerInstancia();

        public void AsignarID(object entidad)
        {
            SqlParameter[] sqlProp = new SqlParameter[] { new SqlParameter("@Tabla", entidad.GetType().Name) };

            int ID = (int)acceso.ObtenerDato("AsignarIDGeneral", sqlProp);
            entidad.GetType().GetProperty("ID").SetValue(entidad, ID);
        }

        public virtual int Agregar(object entidad, string storedProc)
        {
            PropertyInfo[] entityProps = entidad.GetType().GetProperties();
            List<SqlParameter> sqlProps = new List<SqlParameter>();

            foreach(PropertyInfo prop in entityProps)
            {
                string nombre = prop.Name;
                object valor = prop.GetValue(entidad);

                SqlParameter sqlProp = new SqlParameter($"{nombre}", valor);
                sqlProps.Add(sqlProp);
            }

            return acceso.Escribir(storedProc, sqlProps.ToArray());
        }

        //Ambos metodos hacen lo mismo, simplemente cambia el storedProc a ejecutar.
        public virtual int Modificar(object entidad, string storedProc) => Agregar(entidad, storedProc); 
        
        public int Eliminar(int id, string storedProc) => acceso.Escribir(storedProc, new SqlParameter[] { new SqlParameter("Id", id)});
        

        public DataTable ObtenerUnoPorId(dynamic id, string storedProc, string nombreEntidad) //Metodo que devuelve un registro en base a su ID.
        {
            SqlParameter[] sqlProp = new SqlParameter[]
            { 
                new SqlParameter("@Tabla", nombreEntidad),
                new SqlParameter("@Id", id) 
            };

            return acceso.Leer(storedProc, sqlProp);
        }

        //Metodo que devuelve todos los registros (sin aplicar filtros).
        public DataTable ObtenerTodos(string storedProc, string nombreEntidad) => acceso.Leer(storedProc, new SqlParameter[] { new SqlParameter("@Tabla", nombreEntidad) });
    }
}
