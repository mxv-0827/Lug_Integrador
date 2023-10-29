using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using BE;
using BLL;
using BLL.Entity_BLLs;
using UI.Validators;

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


                Generic_Validator<Usuario_Logueo>.PropertiesValidation(usuario_Logueo); //Validacion de propiedades.

                DataTable tabla = usuario_BLL.IniciarSesion(usuario_Logueo);
                DataRow usuarioLogueado = tabla.Rows[0];

                usuario = (Usuario)usuarioLogueado;

                MessageBox.Show("Logueo exitoso");

                if(usuario.IDRol == 1) //Formularios para clientes.
                {
                }

                else //Formulario para admins.
                {
                    Frm_AdminDashboard frm_Admin = new Frm_AdminDashboard();
                    frm_Admin.UsuarioLogueado = usuario;

                    this.Hide();
                    frm_Admin.ShowDialog();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            Frm_Registro frm_Registro = new Frm_Registro();

            this.Hide();
            frm_Registro.ShowDialog();
        }
    }
}
