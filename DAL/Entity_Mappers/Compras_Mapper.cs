using BE;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity_Mappers
{
    public class Compras_Mapper : Base_Mapper
    {
        public DataTable ObtenerComprasPorDNI(int dni) => acceso.Leer("ObtenerComprasPorDNI", new SqlParameter[] { new SqlParameter("@Usuario_DNI", dni) });
    }
}
