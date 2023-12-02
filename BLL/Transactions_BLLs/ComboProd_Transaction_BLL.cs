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
    public class ComboProd_Transaction_BLL : Base_BLL
    {
        private readonly Producto_Mapper Producto_Mapper = new Producto_Mapper();


        public int AgregarEntidades(Combos combo, List<Productos> lstProductos)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                transacciones_Gestor.IniciarTransaccion();

                int cantCombosAfectados = 0;
                int cantProdCombAfectados = 0;

                lstProductos.ForEach(prod => combo.Precio += Producto_Mapper.ObtenerPrecioProducto(prod.ID));
                combo.Precio -= combo.Precio * 0.10m; //El precio total es 10% mas barato a comprar lo mismo por separado.

                base.AsignarID(combo);
                cantCombosAfectados += base.AgregarEntidad(combo);


                foreach (Productos prod in lstProductos)
                {
                    var prodEnCombo = new ProductosEnCombos { IDCombo = combo.ID, IDProducto = prod.ID };
                    cantProdCombAfectados += base.AgregarEntidad(prodEnCombo);
                }

                if (cantCombosAfectados + cantProdCombAfectados < lstProductos.Count + 1) throw new Exception();

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
