using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class HorarioPeliculas_BLL : Base_BLL
    {
        public DataTable ObtenerHorariosCoincidentes(DateTime Fecha, int IDSala) => base.EjecutarConsultaEspecifica<DataTable>("ObtenerHorariosCoincidentes", new { Fecha, IDSala });

        public DataTable ObtenerHorariosPorFechaYPelicula(int IDPelicula) => base.EjecutarConsultaEspecifica<DataTable>("ObtenerHorariosPorFechaYPelicula", new { Fecha = DateTime.Now, IDPelicula });
    }
}
