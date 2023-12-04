using BE;
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
        public DataTable ObtenerRegistrosPorIDHorarioPelicula(int idHorarioPelicula) => base.EjecutarConsultaEspecifica<DataTable>("ObtenerRegistrosPorIDHorarioPelicula", new { IDHorarioPelicula = idHorarioPelicula });
    }
}
