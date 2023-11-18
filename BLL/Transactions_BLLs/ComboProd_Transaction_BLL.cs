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
        Base_BLL<Combos> Base_BLL_Combos = new Base_BLL<Combos>();

        Base_Mapper<ProductosEnCombos> Base_Mapper = new Base_Mapper<ProductosEnCombos>();
        Producto_Mapper Producto_Mapper = new Producto_Mapper();

        public int AgregarEntidad(Combos combo, List<Productos> listaProductos)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                if (listaProductos.Count < 2) throw new FormatException();

                foreach (Productos prod in listaProductos)
                {
                    combo.Precio += Producto_Mapper.ObtenerPrecioProducto(prod.ID);
                }
                combo.Precio -= combo.Precio * 0.10m; //El precio total es 10% mas barato a comprar lo mismo por separado.

                Base_BLL_Combos.AsignarID(combo);

                transacciones_Gestor.IniciarTransaccion();

                int cantCombosAfectados = Base_BLL_Combos.AgregarEntidad(combo);
                int cantProdCombAfectados = 0;

                foreach (Productos prod in listaProductos)
                {
                    var prodEnCombo = new ProductosEnCombos { IDCombo = combo.ID, IDProducto = prod.ID };
                    cantProdCombAfectados += Base_Mapper.Agregar(prodEnCombo, "AgregarProductosEnCombos");
                }

                if (cantCombosAfectados + cantProdCombAfectados < listaProductos.Count + 1) throw new Exception();

                transacciones_Gestor.ConfirmarTransaccion();
                return cantCombosAfectados + cantProdCombAfectados;
            }

            catch (FormatException)
            {
                throw new Exception("Es necesario agregar aunque sea 2 productos para crear un combo.");
            }

            catch (Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("No pudo crearse el combo correctamente.");
            }
        }
    }
}
