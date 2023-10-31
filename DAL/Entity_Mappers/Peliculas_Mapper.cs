using BE;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity_Mappers
{
    public class Peliculas_Mapper : Base_Mapper<Peliculas>
    {
        public TimeSpan ObtenerDuracion(int peliculaID)
        {
            List<SqlParameter> sqlprop = new List<SqlParameter> { new SqlParameter("@IDPelicula", peliculaID)};
            return (TimeSpan)acceso.ObtenerDato("ObtenerDuracionPelicula", sqlprop.ToArray());
        }
    }
}
