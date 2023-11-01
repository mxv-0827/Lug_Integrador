using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Combos
    {
        //Propiedades
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
        public int IDMembresia { get; set; }

        //Constructores
        public Combos() { }


        public Combos(DataRow fila)
        {
            ID = Convert.ToInt32(fila["ID"]);
            Nombre = fila["Nombre"].ToString();
            Descripcion = fila["Descripcion"].ToString();
            Precio = Convert.ToDecimal(fila["Precio"]);
            Imagen = fila["Imagen"].ToString();
            IDMembresia = Convert.ToInt32(fila["IDMembresia"]);
        }


        //Metodos
        public static explicit operator Combos(DataRow fila)
        {
            return new Combos(fila);
        }
    }
}
