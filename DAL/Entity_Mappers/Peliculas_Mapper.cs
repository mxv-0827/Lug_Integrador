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
    public class Peliculas_Mapper : Base_Mapper
    {
        public TimeSpan ObtenerDuracion(int peliculaID) => (TimeSpan)acceso.ObtenerDato("ObtenerDuracionPelicula", new SqlParameter[] { new SqlParameter("@IDPelicula", peliculaID) });
    }
}
