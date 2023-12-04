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

namespace BLL.Transactions_BLLs
{
    public class HorPelDispoAsi_Transaction_BLL : Base_BLL
    {
        public int AgregarEntidades(HorarioPeliculas horarioPelicula)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                transacciones_Gestor.IniciarTransaccion();

                DataTable registroAsientos = base.EjecutarConsultaEspecifica<DataTable>("ObtenerAsientosPorSala", new { horarioPelicula.IDSala });

                base.AsignarID(horarioPelicula);
                horarioPelicula.HoraFin = horarioPelicula.HoraInicio + base.EjecutarConsultaEspecifica<TimeSpan>("ObtenerDuracionPelicula", new { horarioPelicula.IDPelicula });

                int cantHorPeliAfectadas = base.AgregarEntidad(horarioPelicula);
                int cantDispoAsiAfectadas = 0;


                foreach (DataRow asiento in registroAsientos.Rows)
                {
                    DisponibilidadAsientos disponibilidadAsientos = new DisponibilidadAsientos
                    {
                        IDHorarioPelicula = horarioPelicula.ID,
                        IDAsiento = (int)asiento["ID"],
                        Estado = true
                    };

                    cantDispoAsiAfectadas += base.AgregarEntidad(disponibilidadAsientos);
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
