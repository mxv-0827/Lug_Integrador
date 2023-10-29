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
    public partial class Frm_Registro : Form
    {
        public Usuario UsuarioLogueado { get; set; }


        public Frm_Registro()
        {
            InitializeComponent();
        }

        private void Frm_Registro_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text += $" {UsuarioLogueado.Nombre} {UsuarioLogueado.Apellido}";
        }
    }
}
