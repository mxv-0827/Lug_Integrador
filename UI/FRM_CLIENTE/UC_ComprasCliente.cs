using BE;
using BLL;
using BLL.Entity_BLLs;
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
    public partial class UC_ComprasCliente : UserControl
    {
        public Usuarios Usuario { get; set; }


        public UC_ComprasCliente()
        {
            InitializeComponent();
        }

        int locationY = 80;
        private void CrearControles(Compras compra)
        {
            Guna2Panel pnl = new Guna2Panel
            {
                Location = new Point(35, locationY),
                Size = new Size(501, 164),
                BackColor = Color.WhiteSmoke,
                BorderThickness = 2,
                BorderColor = Color.Black
            };

            Guna2HtmlLabel lbl1 = new Guna2HtmlLabel
            {
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Location = new Point(25, 19),
                Text = $"Nro Factura: {compra.ID}",
            };

            Guna2HtmlLabel lbl2 = new Guna2HtmlLabel
            {
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Location = new Point(25, 52),
                Text = $"Fecha de Compra: {compra.Fecha_Compra.ToString().Substring(0, 10)}",
            };

            Guna2HtmlLabel lbl3 = new Guna2HtmlLabel
            {
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Location = new Point(25, 85),
                Text = $"Precio Total: ${compra.PrecioFinal}",
            };

            Guna2HtmlLabel lbl4 = new Guna2HtmlLabel
            {
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Location = new Point(25, 119),
                Text = $"Cupon usado: {(compra.IDCupon == "" ? "-" : compra.IDCupon)}",
            };


            HorarioPeliculas horPeli = (HorarioPeliculas)Base_BLL_HorarioPeliculas.ObtenerEntidadPorId("HorarioPeliculas", compra.IDHoraPelicula).Rows[0];


            Guna2HtmlLabel lbl5 = new Guna2HtmlLabel
            {
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Location = new Point(260, 19),
                Text = $"Fecha de Transmision: {horPeli.Fecha.ToString().Substring(0, 10)}",
            };

            Guna2HtmlLabel lbl6 = new Guna2HtmlLabel
            {
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Location = new Point(260, 52),
                Text = $"HoraInicio: {horPeli.HoraInicio}",
            };

            Guna2HtmlLabel lbl7 = new Guna2HtmlLabel
            {
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Location = new Point(260, 85),
                Text = $"Hora de Fin: {horPeli.HoraFin}",
            };

            int cantCompras = Boletos_BLL.ObtenerCantBoletosPorIDCompra(compra.ID);

            Guna2HtmlLabel lbl8 = new Guna2HtmlLabel
            {
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Location = new Point(260, 119),
                Text = $"Cant. Boletos: {cantCompras}",
            };

            pnl.Controls.Add(lbl1);
            pnl.Controls.Add(lbl2);
            pnl.Controls.Add(lbl3);
            pnl.Controls.Add(lbl4);
            pnl.Controls.Add(lbl5);
            pnl.Controls.Add(lbl6);
            pnl.Controls.Add(lbl7);
            pnl.Controls.Add(lbl8);

            this.Controls.Add(pnl);

            locationY += pnl.Height + 27;
        }



        Base_BLL<HorarioPeliculas> Base_BLL_HorarioPeliculas = new Base_BLL<HorarioPeliculas>();

        Compras_BLL Compras_BLL = new Compras_BLL();
        Boletos_BLL Boletos_BLL = new Boletos_BLL();

        private void UC_ComprasCliente_Enter(object sender, EventArgs e)
        {
            DataTable tableCompras = Compras_BLL.ObtenerComprasPorDNI(Usuario.DNI);

            foreach(DataRow row in tableCompras.Rows)
            {
                Compras compra = (Compras)row;
                CrearControles(compra);
            }
        }
    }
}
