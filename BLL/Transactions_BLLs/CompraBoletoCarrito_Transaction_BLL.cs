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
using DAL.Entity_Mappers;

namespace BLL.Transactions_BLLs
{
    public class CompraBoletoCarrito_Transaction_BLL
    {
        Base_BLL<Compras> Base_BLL_Compras = new Base_BLL<Compras>();
        Base_BLL<Boletos> Base_BLL_Boletos = new Base_BLL<Boletos>();
        Base_BLL<Carrito> Base_BLL_Carritos = new Base_BLL<Carrito>();
        Base_BLL<DisponibilidadAsientos> Base_BLL_DisponibilidadAsientos = new Base_BLL<DisponibilidadAsientos>();
        Base_BLL<Productos> Base_BLL_Productos = new Base_BLL<Productos>();


        Boletos_Mapper Boletos_Mapper = new Boletos_Mapper();
        Carrito_Mapper Carrito_Mapper = new Carrito_Mapper();


        public int AgregarEntidades(Compras compra, List<Boletos> lstBoletos, List<Carrito> lstCarrito)
        {
            Transacciones_Gestor transacciones_Gestor = Transacciones_Gestor.ObtenerInstancia();

            try
            {
                Base_BLL_Compras.AsignarID(compra);
                lstBoletos.ForEach(x => compra.PrecioFinal += x.Precio); //Le sumamos el precio de todos los boletos.
                lstCarrito.ForEach(x => compra.PrecioFinal += x.Subtotal); //Le sumamos el precio de todos los productos.

                int totalidadBoletos = Boletos_Mapper.ObtenerTotalidadBoletos(); //Usado como base para asignar IDs.
                int totalidadCarritos = Carrito_Mapper.ObtenerTotalidadCarritos(); //Usado como base para asignar IDs.


                transacciones_Gestor.IniciarTransaccion();
 
                int cantComprasAfectadas = Base_BLL_Compras.AgregarEntidad(compra);
                int cantBoletosAfectados = 0;
                int cantCarritoAfectados = 0;

                for(int i = 0; i < lstBoletos.Count; i++)
                {
                    Boletos boleto = lstBoletos[i];
                    boleto.ID = totalidadBoletos + 1;
                    boleto.IDCompra = compra.ID;

                    cantBoletosAfectados += Base_BLL_Boletos.AgregarEntidad(boleto);
                    totalidadBoletos++;
                }

                for (int i = 0; i < lstCarrito.Count; i++)
                {
                    Carrito carrito = lstCarrito[i];
                    carrito.ID = totalidadCarritos + 1;
                    carrito.IDCompra = compra.ID;

                    cantCarritoAfectados += Base_BLL_Carritos.AgregarEntidad(carrito);
                    totalidadCarritos++;
                }

                if (cantComprasAfectadas + cantBoletosAfectados + cantCarritoAfectados < lstBoletos.Count + lstCarrito.Count + 1) throw new Exception();


                //Actualizamos el estado de los asientos escogidos por boletos.
                int disponibilidadAsientosAfectados = 0;

                foreach(Boletos boleto in lstBoletos)
                {
                    DisponibilidadAsientos disponibilidadAsientos = new DisponibilidadAsientos
                    {
                        IDHorarioPelicula = compra.IDHoraPelicula,
                        IDAsiento = boleto.IDAsiento,
                        Estado = false //Decimos asi que esta ocupado.
                    };

                    Base_BLL_DisponibilidadAsientos.ModificarEntidad(disponibilidadAsientos);
                    disponibilidadAsientosAfectados++;
                }

                if (disponibilidadAsientosAfectados < lstBoletos.Count) throw new Exception();


                //Actualizamos el stock de los productos adquiridos en el carrito.
                int productosAfectados = 0;

                foreach (Carrito carrito in lstCarrito)
                {
                    Productos producto = (Productos)Base_BLL_Productos.ObtenerEntidadPorId("Productos", carrito.IDProducto).Rows[0];
                    producto.Stock -= carrito.Cantidad;

                    Base_BLL_Productos.ModificarEntidad(producto);
                    productosAfectados++;
                }

                if (productosAfectados < lstCarrito.Count) throw new Exception();


                transacciones_Gestor.ConfirmarTransaccion();
                return cantComprasAfectadas + cantBoletosAfectados + cantCarritoAfectados + disponibilidadAsientosAfectados + productosAfectados;
            }

            catch (Exception)
            {
                transacciones_Gestor.RevertirTransaccion();
                throw new Exception("No puedo agregarse la pelicula correctamente.");
            }
        }
    }
}
