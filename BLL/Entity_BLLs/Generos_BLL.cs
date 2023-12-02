using BE;
using DAL.Entity_Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class Generos_BLL : Base_BLL
    {
        private readonly Generos_Mapper Generos_Mapper = new Generos_Mapper();


        public DataTable ObtenerGenerosPorIdPelicula(int idPelicula) => Generos_Mapper.ObtenerGenerosPorIDPelicula(idPelicula);
    }
}
