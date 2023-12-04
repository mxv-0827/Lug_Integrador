using BE;
using DAL;
using DAL.Mappers;
using SEC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class Cupones_BLL : Base_BLL
    {
        public string ObtenerCodigo()
        {
            string codigoCupon;
            bool valido;

            do
            {
                codigoCupon = CodigoUnico_Generador.CrearCodigo();
                valido = base.EjecutarConsultaEspecifica<int>("ValidarCodigo", new { Codigo = codigoCupon }) == 1;
            }
            while (!valido);

            return codigoCupon;
        }
        

        public override int AgregarEntidad(object entidad) //Aplicamos transaccion.
        {
            Cupones cupon = (Cupones)entidad;

            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();
            transacciones_Gestor.IniciarTransaccion();

            try
            {
                int linesAffected = base.AgregarEntidad(cupon);

                if (linesAffected < 1) throw new Exception();

                transacciones_Gestor.ConfirmarTransaccion();

                return linesAffected;
            }

            catch(Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("No pudo crearse el cupon en la BD");
            }
        }


        public override int ModificarEntidad(object entidad) //Aplicamos transaccion.
        {
            Cupones cupon = (Cupones)entidad;

            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();
            transacciones_Gestor.IniciarTransaccion();

            try
            {
                int linesAffected = base.ModificarEntidad(cupon);

                if (linesAffected < 1) throw new Exception();

                transacciones_Gestor.ConfirmarTransaccion();

                return linesAffected;
            }

            catch (Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("No pudo modificarse el cupon en la BD");
            }
        }
    }
}
