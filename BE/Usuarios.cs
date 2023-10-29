using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuarios
    {
        //Props
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int IDMembresia { get; set; }
        public int IDRol { get; set; }


        //Contructores
        public Usuarios() { }

        public Usuarios(DataRow fila) //Usado para hacer conversion explicita entre un DataRow y un Usuario.
        {
            DNI = Convert.ToInt32(fila["DNI"]);
            Nombre = fila["Nombre"].ToString();
            Apellido = fila["Apellido"].ToString();
            Sexo = fila["Sexo"].ToString();
            Fecha_Nacimiento = Convert.ToDateTime(fila["Fecha_Nacimiento"]);
            IDMembresia = fila["IDMembresia"] != DBNull.Value ? Convert.ToInt32(fila["IDMembresia"]) : 0;
            IDRol = Convert.ToInt32(fila["IDRol"]);
        }


        //Metodos
        public static explicit operator Usuarios(DataRow fila) //Metodo que permite realizar la conversion explicita.
        {
            return new Usuarios(fila);
        }

    }
}
