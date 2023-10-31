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

        public static BD_Conexion ObtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new BD_Conexion();
            }

            return instancia;
        }

        internal void AbrirConexion() => conexion.Open();
        internal void CerrarConexion() => conexion.Close();

        public SqlTransaction GetTransaction() 
        {
            return conexion.BeginTransaction();
        }


        internal int Escribir(string storedProc, SqlParameter[] props)
        {
            int linesAffected;

            SqlCommand command = new SqlCommand(storedProc, conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(props);

            var transaccion = Transacciones_Gestor.ObtenerInstancia();
            command.Transaction = transaccion.GetTransaction();

            try
            {
                linesAffected = command.ExecuteNonQuery();
            }
            catch
            {
                linesAffected = -1;
            }

            return linesAffected;
        }


        internal DataTable Leer(string storedProc, SqlParameter[] props = null)
        {
            //El sqlDataAdapter gestiona internamente la conexion a la BD, por ende no es necesario poner los metodos de conexion aca.

            DataTable tabla = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(storedProc, conexion);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            
            if(props != null) adapter.SelectCommand.Parameters.AddRange(props);

            adapter.Fill(tabla);

            return tabla;
        }


        internal void AsignarID(string storedProc, SqlParameter nombreTabla, object instanciaEntidad)
        {
            SqlCommand command = new SqlCommand(storedProc, conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(nombreTabla);

            command.Transaction = Transacciones_Gestor.ObtenerInstancia().GetTransaction();

            PropertyInfo idProp = instanciaEntidad.GetType().GetProperties()[0]; //Devuelve la primera propiedad que seria el ID (la PK).
            idProp.SetValue(instanciaEntidad, command.ExecuteScalar());
        }

        internal bool ValidarID(string storedProc, SqlParameter codigo) //Usado en casos donde el ID debe ser un conjunto de caracteres aleatorios. => 'Cupones'
        {
            AbrirConexion();

            SqlCommand command = new SqlCommand(storedProc, conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(codigo);

            int valido = int.Parse(command.ExecuteScalar().ToString());
            bool validez = (valido == 1);

            CerrarConexion();

            return validez;
        }

        internal object ObtenerDato(string storedProc, SqlParameter[] props = null)
        {
            AbrirConexion();

            SqlCommand command = new SqlCommand(storedProc, conexion);
            command.CommandType = CommandType.StoredProcedure;
            if(props != null) command.Parameters.AddRange(props);

            object resultado = command.ExecuteScalar();

            CerrarConexion();

            return resultado;
        }
    }
}
