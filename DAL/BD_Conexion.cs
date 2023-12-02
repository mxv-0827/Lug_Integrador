using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class BD_Conexion
    {
        public static BD_Conexion instancia;
        private readonly SqlConnection conexion = new SqlConnection("Server=DESKTOP-GDEVITI\\SQLEXPRESS; Database=Lug_Integrador; Integrated Security= true");


        public static BD_Conexion ObtenerInstancia() => instancia ?? (instancia = new BD_Conexion());


        internal void AbrirConexion() => conexion.Open();
        internal void CerrarConexion() => conexion.Close();


        internal SqlTransaction GetTransaction() => conexion.BeginTransaction();
        

        internal int Escribir(string sp, SqlParameter[] sqlProps)
        {
            var transaccion = Transacciones_Gestor.ObtenerInstancia().GetTransaction();
            int linesAffected;

            using (SqlCommand command = new SqlCommand(sp, conexion))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(sqlProps);
                    command.Transaction = transaccion;

                    linesAffected = command.ExecuteNonQuery();
                }
                catch
                {
                    linesAffected = -1;
                }

                return linesAffected;
            }
        }


        internal DataTable Leer(string sp, SqlParameter[] sqlProps = null)
        {
            //El sqlDataAdapter gestiona internamente la conexion a la BD en su metodo 'Fill', por ende no es necesario poner los metodos de conexion aca.

            DataTable tabla = new DataTable();
            var transaccion = Transacciones_Gestor.ObtenerInstancia().GetTransaction();

            using (SqlDataAdapter adapter = new SqlDataAdapter(sp, conexion))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddRange(sqlProps ?? Array.Empty<SqlParameter>());
                adapter.SelectCommand.Transaction = transaccion;

                adapter.Fill(tabla);

                return tabla;
            }
        }


        internal object ObtenerDato(string sp, SqlParameter[] sqlProps = null)
        {
            var transaccion = Transacciones_Gestor.ObtenerInstancia().GetTransaction();
            object resultado;

            if (transaccion == null) AbrirConexion();
            
            using (SqlCommand command = new SqlCommand(sp, conexion))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(sqlProps ?? Array.Empty<SqlParameter>());
                command.Transaction = transaccion;

                resultado = command.ExecuteScalar();
            }

            if (transaccion == null) CerrarConexion();

            return resultado;
        }
    }
}
