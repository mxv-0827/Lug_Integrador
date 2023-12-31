﻿using System;
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
        private readonly BD_Conexion conexion;
        private SqlTransaction transaction;


        private Transacciones_Gestor()
        {
            conexion = BD_Conexion.ObtenerInstancia();
        }


        public static Transacciones_Gestor ObtenerInstancia() => instancia ?? (instancia = new Transacciones_Gestor());

        public void IniciarTransaccion()
        {
            conexion.AbrirConexion();
            transaction = conexion.GetTransaction();
        }

        public void ConfirmarTransaccion()
        {
            transaction.Commit();
            conexion.CerrarConexion();
            instancia = null; // Marcar como completada y liberar la transacción.
        }

        public void RevertirTransaccion()
        {
            transaction.Rollback();
            conexion.CerrarConexion();
            instancia = null; // Marcar como revertida y liberar la transacción.
        }

        public SqlTransaction GetTransaction() => transaction;
    }
}
