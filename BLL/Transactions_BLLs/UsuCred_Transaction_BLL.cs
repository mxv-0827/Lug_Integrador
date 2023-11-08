using BE;
using BLL.Entity_BLLs;
using DAL;
using DAL.Entity_Mappers;
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
        private readonly Base_BLL<Usuarios> base_BLL_Usuarios = new Base_BLL<Usuarios>();
        private readonly Credenciales_Mapper Credenciales_Mapper = new Credenciales_Mapper();

        public int CrearEntidades(Usuarios usuario, Credenciales credenciales)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                transacciones_Gestor.IniciarTransaccion();

                int cantUsuariosAfectados = base_BLL_Usuarios.AgregarEntidad(usuario);
                int cantCredencialesAfectadas = Credenciales_Mapper.Agregar(credenciales, "AgregarCredenciales"); //No hace el de Base_BLL xq requiere encriptar la password.

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
