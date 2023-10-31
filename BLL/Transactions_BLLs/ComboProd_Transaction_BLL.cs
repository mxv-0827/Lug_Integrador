using BE;
using BE.Tabla_Intermedia;
using DAL;
using DAL.Entity_Mappers;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Transactions_BLLs
{
    public class ComboProd_Transaction_BLL
    {
        Base_BLL<Combos> Base_BLL = new Base_BLL<Combos>();

        Base_Mapper<ProductosEnCombos> Base_Mapper = new Base_Mapper<ProductosEnCombos>();
        Producto_Mapper Producto_Mapper = new Producto_Mapper();

        public int AgregarEntidad(Combos combo, List<int> productosID)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                foreach(int ID in productosID)
                {
                    combo.Precio += Producto_Mapper.ObtenerPrecioProducto(ID);
                }

                transacciones_Gestor.IniciarTransaccion();

                int cantCombosAfectados = Base_BLL.AgregarEntidad(combo);
                int cantProdCombAfectados = 0;

                foreach (int ID in productosID)
                {
                    var prodEnCombo = new ProductosEnCombos { IDCombo = combo.ID, IDProducto = ID };
                    cantProdCombAfectados += Base_Mapper.Agregar(prodEnCombo, "AgregarProductosEnCombos");
                }

                if (cantCombosAfectados + cantProdCombAfectados < productosID.Count + 1) throw new Exception();

                transacciones_Gestor.ConfirmarTransaccion();
                return cantCombosAfectados + cantProdCombAfectados;
            }

            catch (Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("No pudo crearse el combo correctamente.");
            }
        }
    }
}
