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
        public DataTable ObtenerAsientosPorSala(int salaID) //Devuelve todos los asientos de una misma sala.
        {
            List<SqlParameter> sqlProp = new List<SqlParameter> { new SqlParameter("@IDSala", salaID) };
            return acceso.Leer("ObtenerAsientosPorSala", sqlProp.ToArray());
        }

        public int ObtenerTotalidadAsientos() //Obtiene la totalidad de asientos. Esto servira para establecer el ID a cada asiento.
        {
            List<SqlParameter> sqlProp = new List<SqlParameter> { new SqlParameter("@Tabla", "Asientos") };
            return (int)acceso.ObtenerDato("ObtenerCantidadRegistros", sqlProp.ToArray());
        }
    }
}
