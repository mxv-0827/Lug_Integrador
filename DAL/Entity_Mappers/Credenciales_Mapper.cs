using BE;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity_Mappers
{
    public class Credenciales_Mapper : Base_Mapper<Credenciales>
    {
        public DataTable IniciarSesion(Credenciales usuarioALogear)
        {
            PropertyInfo[] propsUsuario = usuarioALogear.GetType().GetProperties();
            List<SqlParameter> sqlProps = new List<SqlParameter>();

            foreach(PropertyInfo prop in propsUsuario)
            {
                string nombre = prop.Name;
                object valor = prop.GetValue(usuarioALogear);

                SqlParameter sqlProp = new SqlParameter($"@{nombre}", valor);

                sqlProps.Add(sqlProp);
            }

            return base.acceso.Leer("Iniciar_Sesion", sqlProps.ToArray());
        }
    }
}
