﻿using BE.Tabla_Intermedia;
using BE;
using DAL.Entity_Mappers;
using DAL.Mappers;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Transactions_BLLs
{
    public class GenPeli_Transaction_BLL
    {
        Base_BLL<Peliculas> Base_BLL = new Base_BLL<Peliculas>();

        Base_Mapper<GenerosEnPeliculas> Base_Mapper = new Base_Mapper<GenerosEnPeliculas>();

        public int AgregarEntidad(Peliculas pelicula, List<int> generosID)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                transacciones_Gestor.IniciarTransaccion();

                int cantPeliculasAfectadas = Base_BLL.AgregarEntidad(pelicula);
                int cantGenPeliAfectadas = 0;

                foreach (int ID in generosID)
                {
                    var genEnPeli = new GenerosEnPeliculas { IDPelicula = pelicula.ID, IDGenero = ID };
                    cantGenPeliAfectadas += Base_Mapper.Agregar(genEnPeli, "AgregarGenerosEnPeliculas");
                }

                if (cantPeliculasAfectadas + cantGenPeliAfectadas < generosID.Count + 1) throw new Exception();

                transacciones_Gestor.ConfirmarTransaccion();
                return cantPeliculasAfectadas + cantGenPeliAfectadas;
            }

            catch (Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("No puedo agregarse la pelicula correctamente.");
            }
        }
    }
}
