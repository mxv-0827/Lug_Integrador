using BE.Tabla_Intermedia;
using BE;
using DAL.Entity_Mappers;
using DAL.Mappers;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSL.Google_Drive;

namespace BLL.Transactions_BLLs
{
    public class GenPeli_Transaction_BLL
    {
        Base_BLL Base_BLL = new Base_BLL();
        Base_Mapper Base_Mapper = new Base_Mapper();

        GoogleDrive_API GoogleDrive_API = new GoogleDrive_API();

        public int AgregarEntidad(Peliculas pelicula, List<Generos> listaGeneros)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                Base_BLL.AsignarID(pelicula);

                transacciones_Gestor.IniciarTransaccion();

                pelicula.Trailer = GoogleDrive_API.SubirVideo(pelicula.Trailer); //Previamente, la prop contiene la ruta del archivo. Luego, se actualiza por el link de Drive.
                int cantPeliculasAfectadas = Base_BLL.AgregarEntidad(pelicula);
                int cantGenPeliAfectadas = 0;

                foreach (Generos genero in listaGeneros)
                {
                    var genEnPeli = new GenerosEnPeliculas { IDPelicula = pelicula.ID, IDGenero = genero.ID };
                    cantGenPeliAfectadas += Base_Mapper.Agregar(genEnPeli, "AgregarGenerosEnPeliculas");
                }

                if (cantPeliculasAfectadas + cantGenPeliAfectadas < listaGeneros.Count + 1) throw new Exception();

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
