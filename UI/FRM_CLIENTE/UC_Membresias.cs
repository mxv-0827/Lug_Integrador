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
    public partial class UC_Membresias : UserControl
    {
        public UC_Membresias()
        {
            InitializeComponent();
        }


        int membresiaElegida;


        public int EstablecerMembresia() => membresiaElegida;


        private void UC_Membresias_Load(object sender, EventArgs e)
        {
            CterBasic.MouseEnter += Cter_MouseEnter;
            CterBasic.MouseLeave += Cter_MouseLeave;
            CterBasic.Click += Cter_MouseClick;

            CterPremium.MouseEnter += Cter_MouseEnter;
            CterPremium.MouseLeave += Cter_MouseLeave;
            CterPremium.Click += Cter_MouseClick;

            CterDeluxe.MouseEnter += Cter_MouseEnter;
            CterDeluxe.MouseLeave += Cter_MouseLeave;
            CterDeluxe.Click += Cter_MouseClick;
        }

        private void Cter_MouseEnter(object sender, EventArgs e)
        {
            Guna2ContainerControl cter = (Guna2ContainerControl)sender;
            cter.BorderThickness = 3;
        }

        private void Cter_MouseLeave(object sender, EventArgs e)
        {
            Guna2ContainerControl cter = (Guna2ContainerControl)sender;
            cter.BorderThickness = 0;
        }

        private void Cter_MouseClick(object sender, EventArgs e)
        {
            Guna2ContainerControl cter = (Guna2ContainerControl)sender;

            if (cter.Name == "CterBasic") membresiaElegida = 1;
            else if (cter.Name == "CterPremium") membresiaElegida = 2;
            else membresiaElegida = 3;

            this.SendToBack();
        }
    }
}
