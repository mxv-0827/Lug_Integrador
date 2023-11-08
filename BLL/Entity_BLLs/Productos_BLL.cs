using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class Productos_BLL : Base_BLL<Productos>
    {
        public new int AgregarEntidad(Productos producto) //NO es un override ya que la creacion de entidades requiere de transacccion. Base_BLL contiene el metodo de creacion. Esta BLL, la transaccion a usar.
        {
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
