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
        }


        //Usuarios
        Usuarios usuario;

        //Crendenciales
        Credenciales credenciales;

        //Usuarios y Credenciales
        UsuCred_Transaction_BLL Base_Transaction_BLL = new UsuCred_Transaction_BLL();

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = new Usuarios
                {
                    DNI = int.Parse(TbxDNI.Text),
                    Nombre = TbxNombre.Text,
                    Apellido = TbxApellido.Text,
                    Fecha_Nacimiento = DateTime.ParseExact(TbxFechaNac.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Sexo = CbxSexo.Text,
                    IDRol = 1,
                    IDMembresia = int.Parse(CbxMembresia.Text)
                };

                credenciales = new Credenciales
                {
                    DNIUsuario = usuario.DNI,
                    Email = TbxEmail.Text,
                    Password = TbxContra.Text
                };

                Generic_Validator<Usuarios>.ValidarPropiedades(usuario);
                Generic_Validator<Credenciales>.ValidarPropiedades(credenciales);

                Base_Transaction_BLL.CrearEntidades(usuario, credenciales);

                MessageBox.Show("Registro exitoso");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
