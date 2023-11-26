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
    public class DisponibilidadAsientos_Mapper : Base_Mapper<DisponibilidadAsientos>
    {
        public DataTable ObtenerRegistrosPorIDHorarioPelicula(int idHorarioPelicula)
        {
            SqlParameter[] sqlProp = new SqlParameter[]
            {
                new SqlParameter("@IDHorarioPelicula", idHorarioPelicula)
            };

            return acceso.Leer("ObtenerRegistrosPorIDHorarioPelicula", sqlProp);
        }
    }
}
