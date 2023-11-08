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
    public class Base_Mapper<T> where T : class
    {
        internal BD_Conexion acceso = BD_Conexion.ObtenerInstancia();

        public void AsignarID(T entity)
        {
            SqlParameter[] sqlProp = new SqlParameter[]
            {
                new SqlParameter("@Tabla", entity.GetType().Name)
            };

            int assignedID = (int)acceso.ObtenerDato("AsignarIDGeneral", sqlProp);

            entity.GetType().GetProperty("ID").SetValue(entity, assignedID);
        }

        public virtual int Agregar(T entity, string storedProc)
        {
            PropertyInfo[] entityProps = entity.GetType().GetProperties();
            List<SqlParameter> sqlProps = new List<SqlParameter>();

            foreach(PropertyInfo prop in entityProps)
            {
                string nombre = prop.Name;
                object valor = prop.GetValue(entity);

                SqlParameter sqlProp = new SqlParameter($"{nombre}", valor);
                sqlProps.Add(sqlProp);
            }

            return acceso.Escribir(storedProc, sqlProps.ToArray());
        }

        public virtual int Modificar(T entity, string storedProc)
        {
            //Ambos metodos hacen lo mismo, simplemente cambia el storedProc a ejecutar.
            return Agregar(entity, storedProc); 
        }

        public int Eliminar(int id, string storedProc)
        {
            List<SqlParameter> sqlProps = new List<SqlParameter> { new SqlParameter("@Id", id) };

            return acceso.Escribir(storedProc, sqlProps.ToArray());
        }

        //Metodo que devuelve un registro en base a su ID.
        public DataTable ObtenerUnoPorId(int id, string storedProc, string nombreEntidad)
        {
            List<SqlParameter> sqlProp = new List<SqlParameter> 
            { 
                new SqlParameter("@Tabla", nombreEntidad),
                new SqlParameter("@Id", id) 
            };

            return acceso.Leer(storedProc, sqlProp.ToArray());
        }

        //Metodo que devuelve todos los registros (sin aplicar filtros).
        public DataTable ObtenerTodos(string storedProc, string nombreEntidad)
        {
            return acceso.Leer(storedProc, new SqlParameter[] { new SqlParameter("@Tabla", nombreEntidad) });
        }
    }
}
