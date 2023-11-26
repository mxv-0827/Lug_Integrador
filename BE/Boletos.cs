using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Boletos
    {
        public int ID { get; set; }
        public int IDCompra { get; set; }
        public int IDAsiento { get; set; }
        public decimal Precio { get; set; }
    }
}
