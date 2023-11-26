using BE;
using BLL;
using BLL.Entity_BLLs;
using BLL.Transactions_BLLs;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.FRM_CLIENTE
{
    public partial class UC_HorarioPelicula : UserControl
    {
        public UC_HorarioPelicula()
        {
            InitializeComponent();
        }


        public HorarioPeliculas HorarioPelicula { get; set; }
        public Usuarios Usuario { get; set; }


        Base_BLL<Salas> Base_BLL_Salas = new Base_BLL<Salas>();
        Base_BLL<Membresias> Base_BLL_Membresias = new Base_BLL<Membresias>();
        Base_BLL<Peliculas> Base_BLL_Peliculas = new Base_BLL<Peliculas>();

        DisponibilidadAsientos_BLL DisponibilidadAsientos_BLL = new DisponibilidadAsientos_BLL();


        int locationX = 187, locationY = 71;
        private void CrearGunaTBX(DisponibilidadAsientos disponibilidadAsientos)
        {
            Guna2TextBox tbx = new Guna2TextBox
            {
                Location = new Point(locationX, locationY),
                Size = new Size(35, 35),
                Text = disponibilidadAsientos.IDAsiento.ToString(),
                TextAlign = HorizontalAlignment.Center,
                Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold),
                ForeColor = Color.Black,
                FillColor = disponibilidadAsientos.Estado ? Color.White : Color.OrangeRed,
                MinimumSize = new Size(35, 35),
                ReadOnly = true,
                Cursor = Cursors.Hand,
                BorderThickness = 0
            };
            tbx.Click += TbxAsiento_Click;

            CterDisposicionAsientos.Controls.Add(tbx);

            locationX += tbx.Size.Width + 10;

            if (locationX == 412 && (locationY == 71 || locationY == 161))
            {
                locationX = 97;
                locationY += tbx.Size.Height + 10;
            }

            else if (locationX == 502 && locationY == 116)
            {
                locationX = 187;
                locationY += tbx.Size.Height + 10;
            }

            else if (locationX == 277 && locationY == 206) locationX += tbx.Size.Width + 10;


            else if (locationX == 502 && locationY == 206)
            {
                locationX = 97;
                locationY += tbx.Size.Height + 10;
            }

            else if (locationY == 251) locationX += tbx.Size.Width + 10;
        }


        

        DataTable tableDisponibilidadAsientos;
        DisponibilidadAsientos disponibilidadAsientos;
        int porcMembresia = 0; //Porcentaje de descuento de la membresia.
        private void UC_HorarioPelicula_Enter(object sender, EventArgs e)
        {
            porcMembresia = (int)Base_BLL_Membresias.ObtenerEntidadPorId("Membresias", Usuario.IDMembresia).Rows[0]["Descuento"];

            LblPelicula.Text = Base_BLL_Peliculas.ObtenerEntidadPorId("Peliculas", HorarioPelicula.IDPelicula).Rows[0]["Nombre"].ToString();

            TbxSala.Text = Base_BLL_Salas.ObtenerEntidadPorId("Salas", HorarioPelicula.IDSala).Rows[0]["Nombre"].ToString();
            TbxFecha.Text = HorarioPelicula.Fecha.ToString().Substring(0, 10);
            TbxHoraInicio.Text = HorarioPelicula.HoraInicio.ToString();
            TbxHoraCierre.Text = HorarioPelicula.HoraFin.ToString();

            tableDisponibilidadAsientos = DisponibilidadAsientos_BLL.ObtenerRegistrosPorIDHorarioPelicula(HorarioPelicula.ID);

            foreach(DataRow row in tableDisponibilidadAsientos.Rows)
            {
                disponibilidadAsientos = (DisponibilidadAsientos)row;

                CrearGunaTBX(disponibilidadAsientos);
            }
        }

        Boletos boleto;
        List<Boletos> lstBoletos = new List<Boletos>();

        private void TbxAsiento_Click(object sender, EventArgs e)
        {
            Guna2TextBox tbx = (Guna2TextBox)sender;
            DgvBoletos.DataSource = null;

            if (tbx.FillColor == Color.Gold)
            {
                tbx.FillColor = Color.White;

                boleto = lstBoletos.Find(x => x.IDAsiento == int.Parse(tbx.Text)); //Encuentra un boleto por su idAsiento. Luego lo borra de la lista.
                lstBoletos.Remove(boleto);
            }

            else if (tbx.FillColor == Color.White)
            {
                tbx.FillColor = Color.Gold;

                boleto = new Boletos
                {
                    IDAsiento = int.Parse(tbx.Text),
                    Precio = HorarioPelicula.PrecioEntrada - (porcMembresia / 100)
                };

                lstBoletos.Add(boleto);
            }

            else
            {
                MessageBox.Show("Este asiento ya fue reservado.");
            }

            DgvBoletos.DataSource = lstBoletos;
            DgvBoletos.ClearSelection();

            DgvBoletos.Columns[0].Visible = false;
            DgvBoletos.Columns[1].Visible = false;

            DgvBoletos.Columns[2].HeaderText = "Nro asiento";
        }


        Compras compra;

        CompraBoletoCarrito_Transaction_BLL CompraBoletoCarrito_Transaction_BLL = new CompraBoletoCarrito_Transaction_BLL();

        private void BtnCompra_Click(object sender, EventArgs e)
        {
            try
            {
                compra = new Compras
                {
                    Usuario_DNI = Usuario.DNI,
                    Fecha_Compra = DateTime.Now,
                    IDHoraPelicula = HorarioPelicula.ID
                };

                CompraBoletoCarrito_Transaction_BLL.AgregarEntidades(compra, lstBoletos, lstCarritos);

                MessageBox.Show("Compra registrada exitosamente");
            }

            catch(Exception)
            {
                MessageBox.Show("No se pudo registrar la compra");
                this.SendToBack();
            }
        }

        List<Carrito> lstCarritos = new List<Carrito>();
        private void BtnProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
