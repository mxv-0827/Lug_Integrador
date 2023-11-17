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
        readonly Base_BLL<Descuentos> Base_BLL_Descuentos = new Base_BLL<Descuentos>();


        private void LlenarDGV() //LLena la datagridview con todos los cupones creados.
        {
            DgvCupones.Rows.Clear();

            DataTable tablaCupones = cupones_BLL.ObtenerTodasEntidades("Cupones");

            for(int i = 0; i < tablaCupones.Rows.Count; i++)
            {
                DataRow row = tablaCupones.Rows[i];
                Cupones cupon = (Cupones)row;

                int porcDescuento = (int)Base_BLL_Descuentos.ObtenerEntidadPorId("Descuentos", cupon.IDDescuento).Rows[0]["Porcentaje"];

                DgvCupones.Rows.Add();

                DgvCupones.Rows[i].Cells[0].Tag = cupon; //Almacenamos el objeto completo.

                DgvCupones.Rows[i].Cells[0].Value = cupon.ID;
                DgvCupones.Rows[i].Cells[1].Value = $"{porcDescuento}%"; //Mostramos el porcentaje del descuento.
                DgvCupones.Rows[i].Cells[2].Value = cupon.Estado;
            }

            DgvCupones.ClearSelection();
        }


        private void UC_Cupones_Load(object sender, EventArgs e)
        {
            PnlSombreado.BackColor = Color.FromArgb(128, 0, 0, 0);

            DataTable tablaDescuentos = Base_BLL_Descuentos.ObtenerTodasEntidades("Descuentos");

            CbxIDDesc.DataSource = tablaDescuentos;
            CbxIDDesc.DisplayMember = "Porcentaje";
            CbxIDDesc.ValueMember = "ID";

            CbxIDDesc.SelectedIndex = -1;

            LlenarDGV();
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

                LlenarDGV();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cupon = null;
            }
        }

        private void DgvCupones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0 && e.ColumnIndex == 2)
                {
                    cupon = (Cupones)DgvCupones.Rows[e.RowIndex].Cells[0].Tag;
                    cupon.Estado = !cupon.Estado;

                    cupones_BLL.ModificarEntidad(cupon);

                    MessageBox.Show("Cupon modificado exitosamente.");

                    LlenarDGV();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cupon = null;
            }
        }
    }
}
