using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using BLL.Entity_BLLs;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Usuarios
        Usuario_BLL usuario_BLL = new Usuario_BLL();
        Usuario_Logueo usuario_Logueo;
        Usuario usuario;

        private void BtnLogeo_Click(object sender, EventArgs e)
        {
            try
            {
                usuario_Logueo = new Usuario_Logueo
                {
                    Email = TbxEmail.Text,
                    Password = TbxContra.Text
                };

                DataTable tabla = usuario_BLL.IniciarSesion(usuario_Logueo);
                DataRow usuarioLogueado = tabla.Rows[0];

                usuario = (Usuario)usuarioLogueado;

                MessageBox.Show("Logueo exitoso");

                if(usuario.IDRol == 1)
                {

                }

                else
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
