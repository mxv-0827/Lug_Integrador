using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Transacciones_Gestor
    {
        private static Transacciones_Gestor instancia;
        private SqlTransaction transaction;
        private BD_Conexion conexion;

        private Transacciones_Gestor()
        {
            conexion = BD_Conexion.ObtenerInstancia();
        }

        public static Transacciones_Gestor ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Transacciones_Gestor();
            }

            return instancia;
        }

        public void IniciarTransaccion()
        {
            conexion.AbrirConexion();
            transaction = conexion.GetTransaction();
        }

        public void ConfirmarTransaccion()
        {
            transaction.Commit();
            transaction = null; // Marcar como completada y liberar la transacción.
        }

        public void RevertirTransaccion()
        {
            transaction.Rollback();
            transaction = null; // Marcar como revertida y liberar la transacción.
            conexion.CerrarConexion();
        }

        public SqlTransaction GetTransaction()
        {
            return transaction;
        }
    }
}
