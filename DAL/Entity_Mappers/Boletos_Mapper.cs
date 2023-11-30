﻿using BE;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity_Mappers
{
    public class Boletos_Mapper : Base_Mapper
    {
        public int ObtenerTotalidadBoletos()
        {
            List<SqlParameter> sqlProp = new List<SqlParameter> { new SqlParameter("@Tabla", "Boletos") };
            return (int)acceso.ObtenerDato("ObtenerCantidadRegistros", sqlProp.ToArray());
        }

        public int ObtenerCantBoletosPorIDCompra(int idCompra)
        {
            SqlParameter[] sqlProp = new SqlParameter[]
            {
                new SqlParameter("@IDCompra", idCompra)
            };

            return (int)acceso.ObtenerDato("ObtenerCantidadBoletosPorIDCompra", sqlProp);
        }
    }
}
