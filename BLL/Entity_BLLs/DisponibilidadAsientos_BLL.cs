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
    public class DisponibilidadAsientos_BLL : Base_BLL
    {
        DisponibilidadAsientos_Mapper DisponibilidadAsientos_Mapper = new DisponibilidadAsientos_Mapper();


        public DataTable ObtenerRegistrosPorIDHorarioPelicula(int idHorarioPelicula)
        {
            return DisponibilidadAsientos_Mapper.ObtenerRegistrosPorIDHorarioPelicula(idHorarioPelicula);
        }
    }
}
