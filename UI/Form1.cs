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
using Svg;
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
        Credenciales_BLL credenciales_BLL = new Credenciales_BLL();
        Usuarios usuario;

        //Credenciales
        Credenciales credenciales;



        private void BtnLogeo_Click(object sender, EventArgs e)
        {
            try
            {
                credenciales = new Credenciales()
                {
                    Email = TbxEmail.Text,
                    Password = TbxContra.Text
                };


                Generic_Validator<Credenciales>.ValidarPropiedades(credenciales); //Validacion de propiedades.

                DataTable tabla = credenciales_BLL.IniciarSesion(credenciales);
                DataRow usuarioLogueado = tabla.Rows[0];

                usuario = (Usuarios)usuarioLogueado;

                MessageBox.Show("Logueo exitoso");

                if(usuario.IDRol == 1) //Formularios para clientes.
                {
                }

                else //Formulario para admins.
                {
                    Frm_AdminDashboard frm_Admin = new Frm_AdminDashboard();
                    frm_Admin.UsuarioLogueado = usuario;

                    this.Hide();
                    frm_Admin.Show();
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
            frm_Registro.Show();
        }
    }
}
