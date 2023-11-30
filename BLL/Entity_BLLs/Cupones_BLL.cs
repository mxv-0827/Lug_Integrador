using BE;
using DAL;
using DAL.Entity_Mappers;
using DAL.Mappers;
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
        Cupones_Mapper cupones_Mapper = new Cupones_Mapper();

        public string ObtenerCodigo() => cupones_Mapper.ValidarCodigo();
        

        public override int AgregarEntidad(object entidad)
        {
            Cupones cupon = (Cupones)entidad;

            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();
            transacciones_Gestor.IniciarTransaccion();

            try
            {
                string spNombre = ObtenerNombreSP("Agregar", cupon.GetType().Name);
                int linesAffected = mapper.Agregar(cupon, spNombre);

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

        public override int ModificarEntidad(object entidad)
        {
            Cupones cupon = (Cupones)entidad;

            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();
            transacciones_Gestor.IniciarTransaccion();

            try
            {
                string spNombre = ObtenerNombreSP("Modificar", cupon.GetType().Name);
                int linesAffected = mapper.Modificar(cupon, spNombre);

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

        public DataTable ObtenerCuponPorID(string id)
        {
            return cupones_Mapper.ObtenerCuponPorID(id);
        }
    }
}
