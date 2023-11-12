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

namespace UI
{
    public partial class Frm_Registro : Form
    {
        public Frm_Registro()
        {
            InitializeComponent();
        }


        //Usuarios
        Usuarios usuario;

        //Crendenciales
        Credenciales credenciales;

        //Membresias (BLL)
        Base_BLL<Membresias> Base_BLL_Membresias = new Base_BLL<Membresias>();

        //Usuarios y Credenciales
        UsuCred_Transaction_BLL Base_Transaction_BLL = new UsuCred_Transaction_BLL();

        
        private void Frm_Registro_Load(object sender, EventArgs e)
        {
            CbxMembresia.DataSource = Base_BLL_Membresias.ObtenerTodasEntidades("Membresias");

            CbxMembresia.DisplayMember = "Nombre";
            CbxMembresia.ValueMember = "ID";
            CbxMembresia.SelectedIndex = -1;
        }

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
                    IDMembresia = CbxMembresia.SelectedIndex == -1 ? 0 : int.Parse(CbxMembresia.SelectedValue.ToString())
                };

                Generic_Validator<Usuarios>.ValidarPropiedades(usuario);

                credenciales = new Credenciales
                {
                    DNIUsuario = usuario.DNI,
                    Email = TbxEmail.Text,
                    Password = TbxContra.Text
                };

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
