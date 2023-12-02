using BE;
using DAL.Mappers;
using SEC;
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
    public class Credenciales_Mapper : Base_Mapper
    {
        public DataTable IniciarSesion(Credenciales usuarioALogear)
        {
            usuarioALogear.Password = Password_Encriptador.EncriptarContraseña(usuarioALogear.Password, usuarioALogear.Email);

            PropertyInfo[] propsUsuario = usuarioALogear.GetType().GetProperties();
            List<SqlParameter> sqlProps = new List<SqlParameter>();

            foreach(PropertyInfo prop in propsUsuario)
            {
                string nombre = prop.Name;
                object valor = prop.GetValue(usuarioALogear);

                SqlParameter sqlProp = new SqlParameter($"@{nombre}", valor);

                sqlProps.Add(sqlProp);
            }
            sqlProps.RemoveAt(0); //Quitamos el ID xq no lo necesitamos. Ademas, tira error si se lo deja.

            return acceso.Leer("Iniciar_Sesion", sqlProps.ToArray());
        }
    }
}
