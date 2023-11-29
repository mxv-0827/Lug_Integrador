using DAL.Entity_Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class Boletos_BLL
    {
        Boletos_Mapper Boletos_Mapper = new Boletos_Mapper();

        public int ObtenerCantBoletosPorIDCompra(int idCompra)
        {
            return Boletos_Mapper.ObtenerCantBoletosPorIDCompra(idCompra);
        }
    }
}
