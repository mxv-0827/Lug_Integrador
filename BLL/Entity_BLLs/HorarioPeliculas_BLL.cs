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
    public class HorarioPeliculas_BLL : Base_BLL<HorarioPeliculas>
    {
        HorarioPeliculas_Mapper HorarioPeliculas_Mapper = new HorarioPeliculas_Mapper();

        public DataTable ObtenerHorariosCoincidentes(DateTime fecha, int IDSala)
        {
            return HorarioPeliculas_Mapper.ObtenerHorariosCoincidentes(fecha, IDSala);
        }
    }
}
