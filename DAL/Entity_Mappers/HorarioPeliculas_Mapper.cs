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
    public class HorarioPeliculas_Mapper : Base_Mapper
    {
        public DataTable ObtenerHorariosCoincidentes(DateTime fecha, int idSala)
        {
            SqlParameter[] sqlProps = new SqlParameter[]
            {
                new SqlParameter("@Fecha", fecha),
                new SqlParameter("@IDSala", idSala)
            };

            return acceso.Leer("ObtenerHorariosCoincidentes", sqlProps);
        }

        public DataTable ObtenerHorariosPorFechaYPelicula(int idPelicula)
        {
            SqlParameter[] sqlProps = new SqlParameter[]
            {
                new SqlParameter("@Fecha", DateTime.Now),
                new SqlParameter("@IDPelicula", idPelicula)
            };

            return acceso.Leer("ObtenerHorariosPorFechaYPelicula", sqlProps);
        }
    }
}
