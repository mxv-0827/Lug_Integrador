using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class Boletos_BLL : Base_BLL
    {
        public int ObtenerCantBoletosPorIDCompra(int idCompra) => base.EjecutarConsultaEspecifica<int>("ObtenerCantidadBoletosPorIDCompra", new { IDCompra = idCompra });
    }
}
