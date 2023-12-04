using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class Compras_BLL : Base_BLL
    {
        public DataTable ObtenerComprasPorDNI(int dni) => base.EjecutarConsultaEspecifica<DataTable>("ObtenerComprasPorDNI", new { Usuario_DNI = dni });
    }
}
