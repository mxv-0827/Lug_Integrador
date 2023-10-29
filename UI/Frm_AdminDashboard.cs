﻿using BE;
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
    public partial class Frm_AdminDashboard : Form
    {
        public Usuario UsuarioLogueado { get; set; }


        public Frm_AdminDashboard()
        {
            InitializeComponent();
        }

        private void Frm_AdminDashboard_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text += $" {UsuarioLogueado.Nombre} {UsuarioLogueado.Apellido}";
        }
    }
}
