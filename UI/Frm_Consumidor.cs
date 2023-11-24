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
    }
}
