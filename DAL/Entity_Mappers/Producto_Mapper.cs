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
    public class Producto_Mapper : Base_Mapper
    {
        public decimal ObtenerPrecioProducto(int idProducto)
        {
            List<SqlParameter> sqlProps = new List<SqlParameter>() { new SqlParameter("@ID", idProducto) };
            return decimal.Parse(acceso.ObtenerDato("ObtenerPrecioProducto", sqlProps.ToArray()).ToString());
        }
    }
}
