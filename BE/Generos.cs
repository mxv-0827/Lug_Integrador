using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Generos
    {
        //Props
        public int ID { get; set; }
        public string Nombre { get; set; }


        //Constructores
        public Generos() { }

        public Generos(DataRow fila)
        {
            ID = Convert.ToInt32(fila["ID"]);
            Nombre = fila["Nombre"].ToString();
        }

        public static explicit operator Generos(DataRow fila) 
        {
            return new Generos(fila);
        }
    }
}
