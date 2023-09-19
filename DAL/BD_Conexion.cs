using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class BD_Conexion
    {
        private readonly SqlConnection conexion = new SqlConnection("Server=DESKTOP-GDEVITI\\SQLEXPRESS; Database=Lug_Integrador; Integrated Security= true");


        private void AbrirConexion() => conexion.Open();
        private void CerrarConexion() => conexion.Close();


        internal int Escribir(string storedProc, SqlParameter[] props)
        {
            AbrirConexion();

            int linesAffected;

            SqlCommand command = new SqlCommand(storedProc, conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(props);

            try
            {
                linesAffected = command.ExecuteNonQuery();
            }
            catch
            {
                linesAffected = -1;
            }
            finally
            {
                CerrarConexion();
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
            AbrirConexion();

            SqlCommand comand = new SqlCommand(storedProc, conexion);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(nombreTabla);

            PropertyInfo idProp = instanciaEntidad.GetType().GetProperty("Id");
            idProp.SetValue(instanciaEntidad, comand.ExecuteScalar());

            CerrarConexion();
        }
    }
}
