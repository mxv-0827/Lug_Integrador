using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Compras
    {
        public int ID { get; set; }
        public int Usuario_DNI { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public int IDHoraPelicula { get; set; }
        public string IDCupon { get; set; }
        public decimal PrecioFinal { get; set; }
    }
}
