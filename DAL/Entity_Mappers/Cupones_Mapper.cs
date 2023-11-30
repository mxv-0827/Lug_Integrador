using BE;
using DAL.Mappers;
using SEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Entity_Mappers
{
    public class Cupones_Mapper : Base_Mapper
    {
        public string ValidarCodigo()
        {
            bool valido = false;
            string codigoCupon = "";

            while (!valido)
            {
                codigoCupon = CodigoUnico_Generador.CrearCodigo();

                SqlParameter[] sqlProp = new SqlParameter[]
                {
                    new SqlParameter("@Codigo", codigoCupon)
                };

                valido = (int)acceso.ObtenerDato("ValidarCodigo", sqlProp) == 1 ? true : false;
            }

            return codigoCupon;
        }


        public DataTable ObtenerCuponPorID(string id)
        {
            SqlParameter[] sqlProp = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };

            return acceso.Leer("ObtenerCuponPorID", sqlProp);
        }
    }
}
