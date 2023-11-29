using DAL.Entity_Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class Compras_BLL
    {
        Compras_Mapper Compras_Mapper = new Compras_Mapper();

        public DataTable ObtenerComprasPorDNI(int dni)
        {
            return Compras_Mapper.ObtenerComprasPorDNI(dni);
        }
    }
}
