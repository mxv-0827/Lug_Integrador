using BE;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity_Mappers
{
    public class Carrito_Mapper : Base_Mapper
    {
        public int ObtenerTotalidadCarritos()
        {
            List<SqlParameter> sqlProp = new List<SqlParameter> { new SqlParameter("@Tabla", "Carrito") };
            return (int)acceso.ObtenerDato("ObtenerCantidadRegistros", sqlProp.ToArray());
        }
    }
}
