using System;
using System.Collections.Generic;
using System.Data;
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



        //Constructores

        public Compras() { }

        public Compras(DataRow fila)
        {
            ID = Convert.ToInt32(fila["ID"]);
            Usuario_DNI = Convert.ToInt32(fila["Usuario_DNI"]);
            Fecha_Compra = Convert.ToDateTime(fila["Fecha_Compra"]);
            IDHoraPelicula = Convert.ToInt32(fila["IDHoraPelicula"]);
            IDCupon = fila["IDCupon"].ToString();
            PrecioFinal = Convert.ToDecimal(fila["PrecioFinal"]);
        }



        //Metodos

        public static explicit operator Compras(DataRow fila) => new Compras(fila);
    }
}
