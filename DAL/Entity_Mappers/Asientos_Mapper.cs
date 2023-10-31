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
    public class Asientos_Mapper : Base_Mapper<Asientos>
    {
        public DataTable ObtenerAsientosPorSala(int salaID) //Devuelve todos los asientos de una misma sala.
        {
            List<SqlParameter> sqlProp = new List<SqlParameter> { new SqlParameter("@IDSala", salaID) };
            return acceso.Leer("ObtenerAsientosPorSala", sqlProp.ToArray());
        }
    }
}
