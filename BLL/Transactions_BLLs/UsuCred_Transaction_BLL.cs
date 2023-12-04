using BE;
using BLL.Entity_BLLs;
using DAL;
using SEC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Transactions_BLLs
{
    public class UsuCred_Transaction_BLL : Base_BLL
    {
        public int AgregarEntidades(Usuarios usuario, Credenciales credenciales)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                credenciales.Password = credenciales.Password = Password_Encriptador.EncriptarContraseña(credenciales.Password, credenciales.Email);

                transacciones_Gestor.IniciarTransaccion();

                int cantUsuariosAfectados = base.AgregarEntidad(usuario);
                int cantCredencialesAfectadas = base.AgregarEntidad(credenciales); 

                if (cantCredencialesAfectadas + cantUsuariosAfectados < 2) throw new Exception();

                transacciones_Gestor.ConfirmarTransaccion();
                return cantUsuariosAfectados + cantCredencialesAfectadas;
            }

            catch (Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("No se pudo cargar el usuario junto con sus credenciales");
            }
        }
    }
}
