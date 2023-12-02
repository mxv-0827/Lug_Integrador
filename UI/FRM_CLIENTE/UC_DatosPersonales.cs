using BE;
using BLL.Transactions_BLLs;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Validators;

namespace UI.FRM_CLIENTE
{
    public partial class UC_DatosPersonales : UserControl
    {
        public UC_DatosPersonales()
        {
            InitializeComponent();
        }

        public UC_Membresias UC_Membresias { get; set; }


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
                    DNI = string.IsNullOrEmpty(TbxDNI.Text) ? 00000000 : int.Parse(TbxDNI.Text),
                    Nombre = TbxNombre.Text,
                    Apellido = TbxApellido.Text,
                    Fecha_Nacimiento = DateTime.TryParseExact(TbxFechaNac.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaNac) ? DateTime.ParseExact(TbxFechaNac.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture) : new DateTime(1111, 11, 11),
                    Sexo = CbxSexo.Text,
                    IDRol = 1,
                    IDMembresia = UC_Membresias.EstablecerMembresia()
                };

                Generic_Validator<Usuarios>.ValidarPropiedades(usuario);

                credenciales = new Credenciales
                {
                    DNIUsuario = usuario.DNI,
                    Email = TbxEmail.Text,
                    Password = TbxContra.Text
                };

                Generic_Validator<Credenciales>.ValidarPropiedades(credenciales);
                Base_Transaction_BLL.AgregarEntidades(usuario, credenciales);

                MessageBox.Show("Registro exitoso");

                Frm_Consumidor frm = new Frm_Consumidor();
                frm.Cliente = usuario;

                this.ParentForm.Hide();
                frm.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnMembresia_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
