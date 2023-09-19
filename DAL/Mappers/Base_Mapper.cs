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
        private BD_Conexion acceso = new BD_Conexion();


        public void AsignarID(T entity)
        {
            Type tipoEntidad = entity.GetType();
            string nombreEntidad = tipoEntidad.Name;

            SqlParameter sqlProp = new SqlParameter("@Tabla", nombreEntidad);

            acceso.AsignarID("AsignarIDGeneral", sqlProp, tipoEntidad); //1- SP a ejecutar || 2- Que tabla se va a usar para asignar el ID || 3- Tipo de entidad a la que se le asigna el ID.
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

            int linesAffected = acceso.Escribir(storedProc, sqlProps.ToArray());

            return linesAffected;
        }

        public virtual int Modificar(T entity, string storedProc)
        {
            //Ambos metodos hacen lo mismo, simplemente cambia el storedProc a ejecutar.
            return Agregar(entity, storedProc); 
        }

        public int Eliminar(int id, string storedProc)
        {
            List<SqlParameter> sqlProps = new List<SqlParameter>
            {
                new SqlParameter("@Id", id)
            };

            int linesAffected = acceso.Escribir(storedProc, sqlProps.ToArray());

            return linesAffected;
        }
    }
}
