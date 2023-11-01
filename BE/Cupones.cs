using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cupones
    {
        //Propiedades
        public string ID { get; set; }
        public int IDDescuento { get; set; }
        public bool Estado { get; set; }


        //Constructores
        public Cupones() { }

        public Cupones(DataRow fila)
        {
            ID = fila["ID"].ToString();
            IDDescuento = Convert.ToInt32(fila["IDDescuento"]);
            Estado = Convert.ToBoolean(fila["Estado"]);
        }


        //Metodos
        public static explicit operator Cupones(DataRow fila)
        {
            return new Cupones(fila);
        }
    }
}
