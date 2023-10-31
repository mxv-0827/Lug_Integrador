using BE;
using BLL;
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

namespace UI.FRM_ADMIN
{
    public partial class UC_Combos : UserControl
    {
        public UC_Combos()
        {
            InitializeComponent();
        }

        //Productos
        Productos producto;
        Productos_BLL Productos_BLL = new Productos_BLL();

        //Combos
        Combos combo;

        //Productos y combos
        ComboProd_Transaction_BLL ComboProd_Transaction_BLL = new ComboProd_Transaction_BLL();

        private void BtnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                producto = new Productos
                {
                    Nombre = TbxNombre.Text,
                    Precio = decimal.Parse(TbxPrecio.Text),
                    Dimension = CbxDimension.Text,
                    Stock = 10, //Por defecto.
                    Imagen = "gg" //Por ahora.
                };

                Productos_BLL.AgregarEntidad(producto);

                MessageBox.Show("Producto creado exitosamente");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCrearCombo_Click(object sender, EventArgs e)
        {
            try
            {
                combo = new Combos
                {
                    Nombre = TbxNombreCombo.Text,
                    Descripcion = TbxDescripcion.Text,
                    Imagen = "gg"
                };

                ComboProd_Transaction_BLL.AgregarEntidad(combo, new List<int> { int.Parse(CbxProd1.Text) });

                MessageBox.Show("Combo creado exitosamente.");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
