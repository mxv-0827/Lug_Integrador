using BE;
using BLL;
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
using UI.Validators;

namespace UI.FRM_ADMIN
{
    public partial class UC_Cupones : UserControl
    {
        public UC_Cupones()
        {
            InitializeComponent();
        }

        //Cupones
        Cupones cupon;
        Cupones_BLL cupones_BLL = new Cupones_BLL();

        //Descuentos (BASE)
        Base_BLL<Descuentos> Base_BLL_Descuentos = new Base_BLL<Descuentos>();

        
        private void LlenarCodigosCBX() //LLena la CBX 'CbxCupones' con todos los IDs de cupones creados.
        {
            CbxCupones.DataSource = null;

            DataTable tablaCupones = cupones_BLL.ObtenerTodasEntidades("Cupones");

            CbxCupones.SelectedIndexChanged -= CbxCupones_SelectedIndexChanged;
            CbxCupones.DataSource = tablaCupones;
            CbxCupones.DisplayMember = "ID";
            CbxCupones.SelectedIndex = -1;
            CbxCupones.SelectedIndexChanged += CbxCupones_SelectedIndexChanged;
        }


        private void UC_Cupones_Load(object sender, EventArgs e)
        {
            DataTable tablaDescuentos = Base_BLL_Descuentos.ObtenerTodasEntidades("Descuentos");

            CbxIDDesc.DataSource = tablaDescuentos;
            CbxIDDesc.DisplayMember = "Porcentaje";
            CbxIDDesc.ValueMember = "ID";

            CbxIDDesc.SelectedIndex = -1;

            LlenarCodigosCBX();
        }

        private void BtnCrearCodigo_Click(object sender, EventArgs e)
        {
            TbxCodigo.Text = cupones_BLL.ObtenerCodigo();
        }

        private void BtnCrearCupon_Click(object sender, EventArgs e)
        {
            try
            {
                cupon = new Cupones
                {
                    ID = TbxCodigo.Text,
                    IDDescuento = CbxIDDesc.SelectedIndex == -1 ? 0 : (int)CbxIDDesc.SelectedValue,
                    Estado = true
                };

                Generic_Validator<Cupones>.ValidarPropiedades(cupon);

                cupones_BLL.AgregarEntidad(cupon);

                MessageBox.Show("Cupon creado exitosamente.");

                TbxCodigo.Clear();
                CbxIDDesc.SelectedIndex = -1;

                LlenarCodigosCBX();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------


        private void CbxCupones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cuponID = CbxCupones.Text;

            DataTable tablaCupones = (DataTable)CbxCupones.DataSource;
            DataRow regitroCupon = tablaCupones.AsEnumerable().First(row => (string)row["ID"] == cuponID);

            cupon = (Cupones)regitroCupon;

            if (cupon.Estado) BtnModificarEstado.Text = "DESHABILITAR CUPON";

            else 
            {
                BtnModificarEstado.Text = "HABILITAR CUPON";
            }
        }

        private void BtnModificarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                //cupon.ID = CbxCupones.SelectedIndex == -1 ? "" : CbxCupones.Text;

                Generic_Validator<Cupones>.ValidarPropiedades(cupon);

                cupon.Estado = !cupon.Estado; //Osea, le asigna el valor opuesto al que tenia previamente.

                cupones_BLL.ModificarEntidad(cupon);

                MessageBox.Show("Cupon modificado exitosamente.");

                LlenarCodigosCBX();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
