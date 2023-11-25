using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Frm_Compra : Form
    {
        public Frm_Compra()
        {
            InitializeComponent();
        }


        public Peliculas Pelicula { get; set; }


        private void Frm_Compra_Load(object sender, EventArgs e)
        {
            uC_Pelicula1.Pelicula = Pelicula;
            uC_Pelicula1.BringToFront();
            uC_Pelicula1.Focus();
        }
    }
}
