using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class Productos_BLL : Base_BLL
    {
        public override int AgregarEntidad(object entidad) 
        {
            Productos producto = (Productos)entidad;

            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                base.AsignarID(producto);

                transacciones_Gestor.IniciarTransaccion();

                int cantProductosAfectados = base.AgregarEntidad(producto);

                if (cantProductosAfectados < 1) throw new Exception();

                transacciones_Gestor.ConfirmarTransaccion();
                return cantProductosAfectados;
            }

            catch (Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("El producto no pudo crearse.");
            }
        }
    }
}
