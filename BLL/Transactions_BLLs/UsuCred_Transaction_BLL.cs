using BE;
using BLL.Entity_BLLs;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Transactions_BLLs
{
    public class UsuCred_Transaction_BLL
    {
        private readonly Usuarios_BLL usuarios_BLL = new Usuarios_BLL();
        private readonly Credenciales_BLL credenciales_BLL = new Credenciales_BLL();

        public int CrearEntidades(Usuarios usuario, Credenciales credenciales)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();
            transacciones_Gestor.IniciarTransaccion();

            try
            {
                int cantUsuariosAfectados = usuarios_BLL.AgregarEntidad(usuario);
                int cantCredencialesAfectadas = credenciales_BLL.AgregarEntidad(credenciales);

                if (cantCredencialesAfectadas + cantUsuariosAfectados < 2) throw new Exception();

                transacciones_Gestor.ConfirmarTransaccion();
                return cantUsuariosAfectados + cantCredencialesAfectadas;
            }

            catch(Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("No se pudo cargar el usuario junto con sus credenciales");
            }
        }
    }
}
