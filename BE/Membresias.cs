﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Membresias
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Descuento { get; set; }


        //Constructores

        public Membresias() { }

        public Membresias(DataRow fila)
        {
            ID = Convert.ToInt32(fila["ID"]);
            Nombre = fila["Nombre"].ToString();
            Descripcion = fila["Descripcion"].ToString();
            Descuento = Convert.ToInt32(fila["Descuento"]);
        }


        //Metodos

        public static explicit operator Membresias(DataRow fila) => new Membresias(fila);

    }
}
