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
    public class Generos_Mapper : Base_Mapper<Generos>
    {
        public DataTable ObtenerGenerosPorIDPelicula(int idPelicula)
        {
            SqlParameter[] sqlProp = new SqlParameter[]
            {
                new SqlParameter("@IDPelicula", idPelicula)
            };

            return acceso.Leer("ObtenerGenerosPorIdPelicula", sqlProp);
        }
    }
}
