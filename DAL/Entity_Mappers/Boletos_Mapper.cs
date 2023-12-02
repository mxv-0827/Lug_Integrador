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
    public class Boletos_Mapper : Base_Mapper
    {
        public int ObtenerCantBoletosPorIDCompra(int idCompra) => (int)acceso.ObtenerDato("ObtenerCantidadBoletosPorIDCompra", new SqlParameter[] { new SqlParameter("@IDCompra", idCompra) });
    }
}
