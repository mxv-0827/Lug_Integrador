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
    public class DisponibilidadAsientos_Mapper : Base_Mapper
    {
        public DataTable ObtenerRegistrosPorIDHorarioPelicula(int idHorarioPelicula) => acceso.Leer("ObtenerRegistrosPorIDHorarioPelicula", new SqlParameter[] { new SqlParameter("@IDHorarioPelicula", idHorarioPelicula) });
    }
}
