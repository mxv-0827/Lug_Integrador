using BE;
using BLL.Entity_BLLs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Transactions_BLLs
{
    public class SalaAsiento_Transaction_BLL
    {
        private readonly Base_BLL<Salas> salas_BLL = new Base_BLL<Salas>();
        private readonly Base_BLL<Asientos> asientos_BLL = new Base_BLL<Asientos>();

        public int CrearEntidades(Salas sala)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                transacciones_Gestor.IniciarTransaccion();

                int cantSalasAfectadas = salas_BLL.AgregarEntidad(sala);
                int cantAsientosAfectados = 0;

                for (int i = 0; i < sala.CapacidadTotal; i++)
                {
                    Asientos asiento = new Asientos
                    {
                        IDSala = sala.ID,
                        NroAsiento = i + 1,
                    };

                    cantAsientosAfectados += asientos_BLL.AgregarEntidad(asiento);
                }

                if (cantSalasAfectadas + cantAsientosAfectados < sala.CapacidadTotal + 1) throw new Exception();

                transacciones_Gestor.ConfirmarTransaccion();
                return cantSalasAfectadas + cantAsientosAfectados;
            }

            catch (Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("No se pudo crear la sala y los asientos correspondientes.");
            }
        }
    }
}
