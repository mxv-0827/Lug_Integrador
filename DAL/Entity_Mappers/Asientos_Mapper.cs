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
    public class Asientos_Mapper : Base_Mapper
    {
        public DataTable ObtenerAsientosPorSala(int salaID) => acceso.Leer("ObtenerAsientosPorSala", new SqlParameter[] { new SqlParameter("@IDSala", salaID) });
    }
}
