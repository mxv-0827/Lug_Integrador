using BE;
using BLL.Entity_BLLs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.FRM_ADMIN
{
    public partial class UC_Cupones : UserControl
    {
        public UC_Cupones()
        {
            InitializeComponent();
        }

        Cupones cupones;
        Cupones_BLL cupones_BLL = new Cupones_BLL();

        private void BtnCrearCodigo_Click(object sender, EventArgs e)
        {
            TbxCodigo.Text = cupones_BLL.ObtenerCodigo();
        }

        private void BtnCrearCupon_Click(object sender, EventArgs e)
        {
            try
            {
                cupones = new Cupones
                {
                    ID = TbxCodigo.Text,
                    IDDescuento = int.Parse(CbxIDDesc.Text),
                    Estado = true
                };

                cupones_BLL.AgregarEntidad(cupones);

                MessageBox.Show("Cupon creado exitosamente.");

                TbxCodigo.Clear();
                CbxIDDesc.SelectedIndex = -1;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }
    }
}
