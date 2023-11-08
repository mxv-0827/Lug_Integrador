using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HorarioPeliculas
    {
        //Props
        public int ID { get; set; }
        public int IDSala { get; set; }
        public int IDPelicula { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }


        //Constructores
        public HorarioPeliculas() { }

        public HorarioPeliculas(DataRow fila)
        {
            ID = Convert.ToInt32(fila["ID"]);
            IDSala = Convert.ToInt32(fila["IDSala"]);
            IDPelicula = Convert.ToInt32(fila["IDPelicula"]);
            Fecha = DateTime.ParseExact(fila["Fecha"].ToString(), "dd/MM/yyyy H:mm:ss", CultureInfo.InvariantCulture);
            HoraInicio = TimeSpan.ParseExact(fila["HoraInicio"].ToString(), "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
            HoraFin = TimeSpan.ParseExact(fila["HoraFin"].ToString(), "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
        }


        //Metodos
        public static explicit operator HorarioPeliculas(DataRow fila)
        {
            return new HorarioPeliculas(fila);
        }
    }
}
