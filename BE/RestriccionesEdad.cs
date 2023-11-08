using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class RestriccionesEdad
    {
        //Props
        public int ID { get; set; }
        public int Edad { get; set; }


        //Constructores
        public RestriccionesEdad() { }

        public RestriccionesEdad(DataRow fila)
        {
            ID = Convert.ToInt32(fila["ID"]);
            Edad = Convert.ToInt32(fila["Edad"]);
        }


        //Metodos
        public static explicit operator RestriccionesEdad(DataRow fila)
        {
            return new RestriccionesEdad(fila);
        }
    }
}
