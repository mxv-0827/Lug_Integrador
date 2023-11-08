using BE.Tabla_Intermedia;
using BE;
using DAL.Mappers;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Entity_Mappers;

namespace BLL.Transactions_BLLs
{
    public class HorPelDispoAsi_Transaction_BLL //HORarioPELicula - DISPOnibilidadASIentos
    {
        Base_BLL<HorarioPeliculas> Base_BLL_HorPeli = new Base_BLL<HorarioPeliculas>();

        Base_Mapper<DisponibilidadAsientos> Base_Mapper = new Base_Mapper<DisponibilidadAsientos>();

        Peliculas_Mapper Peliculas_Mapper = new Peliculas_Mapper();
        Asientos_Mapper Asientos_Mapper = new Asientos_Mapper();


        public int AgregarEntidad(HorarioPeliculas horarioPelicula)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                horarioPelicula.HoraFin = horarioPelicula.HoraInicio + Peliculas_Mapper.ObtenerDuracion(horarioPelicula.IDPelicula);
                DataTable registroAsientos = Asientos_Mapper.ObtenerAsientosPorSala(horarioPelicula.IDSala);

                Base_BLL_HorPeli.AsignarID(horarioPelicula);

                transacciones_Gestor.IniciarTransaccion();

                int cantHorPeliAfectadas = Base_BLL_HorPeli.AgregarEntidad(horarioPelicula);
                int cantDispoAsiAfectadas = 0;


                foreach (DataRow asiento in registroAsientos.Rows)
                {
                    cantDispoAsiAfectadas += Base_Mapper.Agregar(new DisponibilidadAsientos { IDHorarioPelicula = horarioPelicula.ID, IDAsiento = (int)asiento["ID"], Estado = true }, "AgregarDisponibilidadAsientos");
                }

                if (cantHorPeliAfectadas + cantDispoAsiAfectadas < registroAsientos.Rows.Count + 1) throw new Exception();

                transacciones_Gestor.ConfirmarTransaccion();
                return cantHorPeliAfectadas + cantDispoAsiAfectadas;
            }

            catch (Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("No puedo agregarse la pelicula correctamente.");
            }
        }
    }
}
