using BE.Tabla_Intermedia;
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
    public class ProductosEnCombo_Mapper : Base_Mapper
    {
        public DataTable ObtenerRegistrosPorIDCombo(int idCombo) => acceso.Leer("ObtenerRegistrosPorIDCombo", new SqlParameter[] { new SqlParameter("@IDCombo", idCombo) });
    }
}
