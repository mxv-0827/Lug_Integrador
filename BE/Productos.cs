using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Productos
    {
        //Propiedades
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Dimension { get; set; }
        public int Stock { get; set; }
        public string Imagen { get; set; }



        public Productos() { }


        public Productos(DataRow fila)
        {
            ID = Convert.ToInt32(fila["ID"]);
            Nombre = fila["Nombre"].ToString();
            Precio = Convert.ToDecimal(fila["Precio"]);
            Dimension = fila["Dimension"].ToString();
            Stock = Convert.ToInt32(fila["Stock"]);
            Imagen = fila["Imagen"].ToString();
        }


        //Metodos
        public static explicit operator Productos(DataRow fila)
        {
            return new Productos(fila);
        }
    }
}
