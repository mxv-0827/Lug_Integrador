using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Peliculas
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Estreno { get; set; }
        public TimeSpan Duracion { get; set; } //HH:mm
        public string Portada { get; set; }
        public string Trailer { get; set; }
        public int IDRestriccion { get; set; }
    }
}
