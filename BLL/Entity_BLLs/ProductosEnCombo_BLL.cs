using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class ProductosEnCombo_BLL : Base_BLL
    {
        public DataTable ObteneRegistrosPorIDCombo(int IDCombo) => base.EjecutarConsultaEspecifica<DataTable>("ObtenerRegistrosPorIDCombo", new { IDCombo });
    }
}
