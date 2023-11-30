using BE;
using BLL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Extras;

namespace UI.FRM_CLIENTE
{
    public partial class UC_Catalogo : UserControl
    {
        public UC_Catalogo()
        {
            InitializeComponent();
        }


        public Usuarios Cliente { get; set; }


        int locationX = 24, locationY = 136;
        private void CrearControles(Peliculas pelicula)
        {
            Guna2Panel pnl = new Guna2Panel
            {
                Location = new Point(locationX, locationY),
                Size = new Size(198, 319),
                UseTransparentBackground = true
            };

            Guna2PictureBox pctbx = new Guna2PictureBox
            {
                Location = new Point(0, 0),
                Size = new Size(198, 255),
                Image = Imagen_Convertidor.HexaAImg(pelicula.Portada),
                InitialImage = Imagen_Convertidor.HexaAImg(pelicula.Portada),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Tag = pelicula
            };
            pctbx.MouseEnter += PctbxPelicula_MouseEnter;
            pctbx.MouseClick += PctbxPelicula_MouseClick;
            pctbx.MouseLeave += PctbxPelicula_MouseLeave;

            Guna2TextBox tbx = new Guna2TextBox
            {
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                BorderThickness = 0,
                Location = new Point(0, pctbx.Height + 6),
                Size = new Size(198, 58),
                Multiline = true,
                ReadOnly = true,
                Text = pelicula.Nombre,
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.Black
            };

            pnl.Controls.Add(pctbx);
            pnl.Controls.Add(tbx);

            this.Controls.Add(pnl);

            locationX += pnl.Width + 120;

            if (locationX > 342)
            {
                locationX = 24;
                locationY += pnl.Height + 35;
            }

            //else locationY = 136;
        }

        

        Peliculas pelicula;

        Base_BLL Base_BLL = new Base_BLL();

        DataTable tablePeliculas;


        private void UC_Catalogo_Enter(object sender, EventArgs e)
        {
            tablePeliculas = Base_BLL.ObtenerTodasEntidades("Peliculas");

            foreach(DataRow row in tablePeliculas.Rows)
            {
                pelicula = (Peliculas)row;
                CrearControles(pelicula);
            }

            CbxPeliculas.SelectedIndexChanged -= CbxPeliculas_SelectedIndexChanged;
            CbxPeliculas.DataSource = null;
            CbxPeliculas.DataSource = tablePeliculas;
            CbxPeliculas.DisplayMember = "Nombre";
            CbxPeliculas.ValueMember = "ID";
            CbxPeliculas.SelectedIndex = -1;
            CbxPeliculas.SelectedIndexChanged += CbxPeliculas_SelectedIndexChanged;
        }

        private void CbxPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationX = 25;
            locationY = 136;

            List<Guna2Panel> lstPnlPeli = this.Controls.OfType<Guna2Panel>().ToList();
            lstPnlPeli.ForEach(x => this.Controls.Remove(x));

            Peliculas pelicula = (Peliculas)tablePeliculas.AsEnumerable().First(row => row["ID"].ToString() == CbxPeliculas.SelectedValue.ToString());
            CrearControles(pelicula);
        }

        private void PctbxPelicula_MouseEnter(object sender, EventArgs e)
        {
            Guna2PictureBox pctbx = (Guna2PictureBox)sender;

            Oscurecimiento_Imagen.OscurecerImagen(pctbx, (float)0.4);

            Guna2HtmlLabel lbl1 = new Guna2HtmlLabel
            {
                Location = new Point(80, 98),
                Size = new Size(35, 27),
                Text = "Ver",
                Font = new Font("Segoe UI Black", 14.25f, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
            };
            lbl1.BringToFront();

            Guna2HtmlLabel lbl2 = new Guna2HtmlLabel
            {
                Location = new Point(28, 131),
                Size = new Size(139, 27),
                Text = "Disponibilidad",
                Font = new Font("Segoe UI Black", 14.25f, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
            };
            lbl2.BringToFront();

            pctbx.Controls.Add(lbl1);
            pctbx.Controls.Add(lbl2);
        }

        private void PctbxPelicula_MouseClick(object sender, MouseEventArgs e)
        {
            Guna2PictureBox pctbx = (Guna2PictureBox)sender;

            Frm_Compra frm = new Frm_Compra
            {
                Pelicula = (Peliculas)pctbx.Tag,
                Usuario = Cliente
            };

            frm.ShowDialog();
        }


        private void PctbxPelicula_MouseLeave(object sender, EventArgs e)
        {
            Guna2PictureBox pctbx = (Guna2PictureBox)sender;

            Oscurecimiento_Imagen.RestaurarImagen(pctbx);

            pctbx.Controls.OfType<Guna2HtmlLabel>().ToList().ForEach(x => pctbx.Controls.Remove(x));
        }

        
        private void BtnReestablecer_Click(object sender, EventArgs e)
        {
            List<Guna2Panel> lstPnlPeli = this.Controls.OfType<Guna2Panel>().ToList();
            lstPnlPeli.ForEach(x => this.Controls.Remove(x));

            CbxPeliculas.SelectedIndexChanged -= CbxPeliculas_SelectedIndexChanged;
            CbxPeliculas.SelectedIndex = -1;
            CbxPeliculas.SelectedIndexChanged += CbxPeliculas_SelectedIndexChanged;

            locationX = 24;
            locationY = 136;

            foreach (DataRow row in tablePeliculas.Rows)
            {
                pelicula = (Peliculas)row;
                CrearControles(pelicula);
            }
        }


        private void UC_Catalogo_Leave(object sender, EventArgs e)
        {
            locationX = 24;
            locationY = 136;

            List<Guna2Panel> lstPnlPeli = this.Controls.OfType<Guna2Panel>().ToList();
            lstPnlPeli.ForEach(x => this.Controls.Remove(x));
        }
    }
}
