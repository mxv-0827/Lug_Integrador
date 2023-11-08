using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Peliculas
    {
        //Props
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Estreno { get; set; }
        public TimeSpan Duracion { get; set; } //HH:mm
        public string Portada { get; set; }
        public string Trailer { get; set; }
        public int IDRestriccion { get; set; }


        //Constructores
        public Peliculas() { }

        public Peliculas(DataRow fila)
        {
            ID = Convert.ToInt32(fila["ID"]);
            Nombre = fila["Nombre"].ToString();
            Descripcion = fila["Descripcion"].ToString();
            Estreno = DateTime.ParseExact(fila["Estreno"].ToString(), "dd/MM/yyyy H:mm:ss", CultureInfo.InvariantCulture);
            Duracion = TimeSpan.ParseExact(fila["Duracion"].ToString(), "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
            Portada = fila["Portada"].ToString();
            Trailer = fila["Trailer"].ToString();
            IDRestriccion = Convert.ToInt32(fila["IDRestriccion"]);
        }

        //Metodos
        public static explicit operator Peliculas(DataRow fila)
        {
            return new Peliculas(fila);
        }
    }
}
