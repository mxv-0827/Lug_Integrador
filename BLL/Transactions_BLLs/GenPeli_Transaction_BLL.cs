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
    public class GenPeli_Transaction_BLL : Base_BLL
    {
        GoogleDrive_API GoogleDrive_API = new GoogleDrive_API();


        public int AgregarEntidades(Peliculas pelicula, List<Generos> listaGeneros)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                transacciones_Gestor.IniciarTransaccion();

                base.AsignarID(pelicula);
                pelicula.Trailer = GoogleDrive_API.SubirVideo(pelicula.Trailer); //Previamente, la prop contiene la ruta del archivo. Luego, se actualiza por el link de Drive.
                int cantPeliculasAfectadas = base.AgregarEntidad(pelicula);

                int cantGenPeliAfectadas = 0;

                foreach (Generos genero in listaGeneros)
                {
                    var genEnPeli = new GenerosEnPeliculas { IDPelicula = pelicula.ID, IDGenero = genero.ID };
                    cantGenPeliAfectadas += base.AgregarEntidad(genEnPeli);
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
