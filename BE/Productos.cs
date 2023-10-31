using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Productos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Dimension { get; set; }
        public int Stock { get; set; }
        public string Imagen { get; set; }
    }
}
