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
        public decimal ObtenerPrecioProducto(int idProducto) => decimal.Parse(acceso.ObtenerDato("ObtenerPrecioProducto", new SqlParameter[] { new SqlParameter("@ID", idProducto) }).ToString());
    }
}
