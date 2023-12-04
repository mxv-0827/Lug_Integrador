using BE;
using BE.Tabla_Intermedia;
using BSL.Google_Drive;
using DAL.Mappers;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL.Entity_BLLs;

namespace BLL.Transactions_BLLs
{
    public class CompraBoletoCarrito_Transaction_BLL : Base_BLL
    {
        private readonly ProductosEnCombo_BLL ProductosEnCombo_BLL = new ProductosEnCombo_BLL();


        //Los descuentos de la entrada, productos y combos ya fueron aplicados previamente.
        public int AgregarEntidades(Compras compra, List<Boletos> lstBoletos, List<Carrito> lstCarrito)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                transacciones_Gestor.IniciarTransaccion();

                base.AsignarID(compra);

                lstBoletos.ForEach(x => compra.PrecioFinal += x.Precio); //Le sumamos el precio de todos los boletos.
                lstCarrito.ForEach(x => compra.PrecioFinal += x.Subtotal); //Le sumamos el precio de todos los productos.


                //Agregamos entidad compra.
                int cantComprasAfectadas = base.AgregarEntidad(compra);
                int cantBoletosAfectados = 0;
                int cantCarritoAfectados = 0;


                foreach (Boletos boleto in lstBoletos) //Asignamos IDs a los boletos y los agregamos.
                {
                    base.AsignarID(boleto);
                    boleto.IDCompra = compra.ID;

                    cantBoletosAfectados += base.AgregarEntidad(boleto);
                }


                foreach(Carrito carrito in lstCarrito) //Registramos todos los productos y combos comprados.
                {
                    base.AsignarID(carrito);
                    carrito.IDCompra = compra.ID;

                    cantCarritoAfectados += base.AgregarEntidad(carrito);
                }

                if (cantComprasAfectadas + cantBoletosAfectados + cantCarritoAfectados < lstBoletos.Count + lstCarrito.Count + 1) throw new Exception();


                
                int disponibilidadAsientosAfectados = 0;

                foreach(Boletos boleto in lstBoletos) //Actualizamos el estado de los asientos escogidos por boletos.
                {
                    DisponibilidadAsientos disponibilidadAsientos = new DisponibilidadAsientos
                    {
                        IDHorarioPelicula = compra.IDHoraPelicula,
                        IDAsiento = boleto.IDAsiento,
                        Estado = false //Decimos asi que esta ocupado.
                    };

                    disponibilidadAsientosAfectados += base.ModificarEntidad(disponibilidadAsientos);
                }

                if (disponibilidadAsientosAfectados < lstBoletos.Count) throw new Exception();

                
                int productosAfectados = 0;
                int prodEnComb = 0;

                foreach (Carrito carrito in lstCarrito) //Actualizamos el stock de los productos y combos adquiridos en el carrito.
                {
                    if (carrito.IDProducto != null)
                    {
                        Productos producto = (Productos)base.ObtenerEntidadPorId("Productos", (int)carrito.IDProducto).Rows[0];
                        producto.Stock -= carrito.Cantidad;

                        productosAfectados += base.ModificarEntidad(producto);
                    }

                    else
                    {
                        DataTable tableProdEnComb = ProductosEnCombo_BLL.ObteneRegistrosPorIDCombo((int)carrito.IDCombo);
                        prodEnComb += tableProdEnComb.Rows.Count;

                        int i = 0;
                        foreach (DataRow row in tableProdEnComb.Rows) //Obtenemos todos los productos que conforman al combo y modificamos su stock..
                        {
                            Productos producto = (Productos)base.ObtenerEntidadPorId("Productos", int.Parse(tableProdEnComb.Rows[i]["IDProducto"].ToString())).Rows[0];
                            producto.Stock -= carrito.Cantidad;

                            productosAfectados += base.ModificarEntidad(producto);
                            i++;
                        }
                    }
                }

                if (productosAfectados < lstCarrito.Count + prodEnComb) throw new Exception();


                transacciones_Gestor.ConfirmarTransaccion();
                return cantComprasAfectadas + cantBoletosAfectados + cantCarritoAfectados + disponibilidadAsientosAfectados + productosAfectados;
            }

            catch (Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("No pudo registrarse la compra correctamente.");
            }
        }
    }
}
