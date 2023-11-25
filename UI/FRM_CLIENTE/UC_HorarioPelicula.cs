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

namespace UI.FRM_CLIENTE
{
    public partial class UC_HorarioPelicula : UserControl
    {
        public UC_HorarioPelicula()
        {
            InitializeComponent();
        }


        public HorarioPeliculas HorarioPelicula { get; set; }

        private void UC_HorarioPelicula_Enter(object sender, EventArgs e)
        {
            guna2Button1.Text = HorarioPelicula.Fecha.ToString();
        }
    }
}
