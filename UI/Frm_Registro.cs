using BE;
using BLL.Entity_BLLs;
using BLL.Transactions_BLLs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using UI.Validators;
using BLL;
using Guna.UI2.WinForms;

namespace UI
{
    public partial class Frm_Registro : Form
    {
        public Frm_Registro()
        {
            InitializeComponent();
        }

        private void Frm_Registro_Load(object sender, EventArgs e)
        {
            uC_DatosPersonales1.UC_Membresias = uC_Membresias1;
        }
    }
}
