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

        Timer UC_Home_TMR = new Timer();

        public Usuarios Cliente { get; set; }


        private void Frm_Consumidor_Load(object sender, EventArgs e)
        {
            uC_Home1.BringToFront();
            uC_Home1.Focus();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            uC_Home1.BringToFront();
            uC_Home1.Focus();
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            UC_Home_TMR = uC_Home1.timer;
            UC_Home_TMR.Stop();

            uC_Catalogo1.BringToFront();
            uC_Catalogo1.Focus();
        }
    }
}
