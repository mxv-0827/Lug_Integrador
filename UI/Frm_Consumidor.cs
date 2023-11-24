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
    public partial class Frm_Consumidor : Form
    {
        public Frm_Consumidor()
        {
            InitializeComponent();
        }


        public Usuarios Cliente { get; set; }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            uC_Home1.BringToFront();
            uC_Home1.Focus();
        }
    }
}
