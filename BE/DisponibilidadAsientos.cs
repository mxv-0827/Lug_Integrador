using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DisponibilidadAsientos
    {
        public int IDHorarioPelicula { get; set; }
        public int IDAsiento { get; set; }
        public bool Estado { get; set; }


        //Constructurores

        public DisponibilidadAsientos() { }

        public DisponibilidadAsientos(DataRow fila)
        {
            IDHorarioPelicula = Convert.ToInt32(fila["IDHorarioPelicula"].ToString());
            IDAsiento = Convert.ToInt32(fila["IDAsiento"].ToString());
            Estado = (bool)fila["Estado"];
        }


        //Metodos
        
        public static explicit operator DisponibilidadAsientos(DataRow fila)
        {
            return new DisponibilidadAsientos(fila);
        }
    }
}
