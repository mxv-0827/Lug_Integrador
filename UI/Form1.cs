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
namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly Base_BLL<Usuario> baseBLL = new Base_BLL<Usuario>();
        Usuario user;

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario
            {
                Nombre = TbxNombre.Text,
                Apellido = TbxApellido.Text,
                Edad = int.Parse(TbxEdad.Text)
            };

            baseBLL.AgregarEntidad(user);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //Dps aca habria que hacer que al seleccionar un registro devuelva un Usuario y asignarlo a 'user'
            user = new Usuario
            {
                Id = int.Parse(TbxId.Text),
                Nombre = TbxNombre.Text,
                Apellido = TbxApellido.Text,
                Edad = int.Parse(TbxEdad.Text)
            };
            
            baseBLL.ModificarEntidad(user);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            baseBLL.EliminarEntidad("Usuario", int.Parse(TbxId.Text));
        }
    }
}
