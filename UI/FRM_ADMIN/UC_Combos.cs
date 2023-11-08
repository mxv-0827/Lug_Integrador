using BE;
using BLL;
using BLL.Entity_BLLs;
using BLL.Transactions_BLLs;
using Guna.UI2.WinForms;
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


        int locationX = 15, locationY = 15;
        private void CrearGunaChip(string nombreProducto)
        {
            Guna2Chip chip = new Guna2Chip
            {
                Location = new Point(locationX, locationY),
                Size = new Size(130, 32),
                UseTransparentBackground = true,
                Text = nombreProducto,
            };

            chip.Click += ChipProd_Click;

            locationX += 170;

            if (locationX > 185)
            {
                locationX = 15;
                locationY += 65;
            }

            CterProductos.Controls.Add(chip);
        }

        
        private void ObtenerProductosCBX()
        {
            tablaProductos = Productos_BLL.ObtenerTodasEntidades("Productos");
            tablaProductos.Columns.Add("Nombre_Dimension", typeof(string)); //Esta columna contiene el nombre y dimension del producto. Ya q puede haber dos prods con el mismo nombre pero no a su vez del mismo tamaño.

            foreach (DataRow row in tablaProductos.Rows)
            {
                producto = (Productos)row; //La conversion no incluye a la columna Nombre_Dimension. Ir a la BE de la entidad para ver.
                row["Nombre_Dimension"] = $"{producto.Nombre} - {producto.Dimension}";

                CbxProductos.Items.Add(row["Nombre_Dimension"].ToString());
            }
        }


        private void ReiniciarProductosCBX() //Borra todos los items de la CBX y los gunaChips del contenedor para insertar el nuevo producto creado.
        {
            CbxProductos.SelectedIndexChanged -= CbxProductos_SelectedIndexChanged;
            CbxProductos.Items.Clear();
            CbxProductos.SelectedIndexChanged += CbxProductos_SelectedIndexChanged;

            CterProductos.Controls.Clear();

            productosAgregados.Clear();

            locationX = 15;
            locationY = 15;
        }

        //Productos
        Productos producto;
        Productos_BLL Productos_BLL = new Productos_BLL();

        //Combos
        Combos combo;

        //Productos y combos
        ComboProd_Transaction_BLL ComboProd_Transaction_BLL = new ComboProd_Transaction_BLL();

        //Membresias (BASE)
        Base_BLL<Membresias> Base_BLL_Membresias = new Base_BLL<Membresias>();


        DataTable tablaProductos; //DataTable donde se almacenan todos los productos encontrados en la BD.
        List<Productos> productosAgregados = new List<Productos>(); //En esta lista se almacenan los productos agregados al combo.

        
        private void UC_Combos_Load(object sender, EventArgs e)
        {
            DataTable tablaMembresias = Base_BLL_Membresias.ObtenerTodasEntidades("Membresias");

            CbxMenbresias.DataSource = tablaMembresias;
            CbxMenbresias.DisplayMember = "Nombre";
            CbxMenbresias.ValueMember = "ID";
        }


        private void UC_Combos_Enter(object sender, EventArgs e)
        {
            ObtenerProductosCBX();
        }


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

                ReiniciarProductosCBX();
                ObtenerProductosCBX();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CbxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrearGunaChip(CbxProductos.Text);

            producto = (Productos)tablaProductos.AsEnumerable().First(row => row["Nombre_Dimension"].ToString() == CbxProductos.Text);
            TbxPrecioCombo.Text = (decimal.Parse(TbxPrecioCombo.Text) + producto.Precio).ToString();

            productosAgregados.Add(producto); //Agregamos a la lista el producto agregado.

            CbxProductos.SelectedIndexChanged -= CbxProductos_SelectedIndexChanged;
            CbxProductos.Items.Remove(CbxProductos.Text);
            CbxProductos.SelectedIndex = -1;
            CbxProductos.SelectedIndexChanged += CbxProductos_SelectedIndexChanged;
        }


        private void ChipProd_Click(object sender, EventArgs e) //Administra las posiciones de los chips dentro del container.
        {
            Guna2Chip chipABorrar = (Guna2Chip)sender;

            //El chip al hacerle click ya se borra solo. No necesita codearse.

            foreach (Guna2Chip chip in CterProductos.Controls)
            {
                if (chip.Location.Y > chipABorrar.Location.Y || (chip.Location.Y == chipABorrar.Location.Y && chip.Location.X > chipABorrar.Location.X))
                {
                    if (chip.Location.X == 15) chip.Location = new Point(chip.Location.X + 170, chip.Location.Y - 65);
                    else chip.Location = new Point(chip.Location.X - 170, chip.Location.Y);
                }
            }

            if (locationX == 15)
            {
                locationX += 170;
                locationY -= 65;
            }
            else locationX -= 170;


            //El gunaChip no contiene el ID del producto, por ende, no hay mas opcion que validar por la columna creada.
            DataRow rowProducto = tablaProductos.AsEnumerable().First(row => row["Nombre_Dimension"].ToString() == chipABorrar.Text);
            producto = (Productos)rowProducto;

            CbxProductos.Items.Add(rowProducto["Nombre_Dimension"]);
            productosAgregados.Remove(producto); //Quitamos de la lista el producto agregado.

            TbxPrecioCombo.Text = (decimal.Parse(TbxPrecioCombo.Text) - producto.Precio).ToString();
        }


        private void BtnCrearCombo_Click(object sender, EventArgs e)
        {
            try
            {
                combo = new Combos
                {
                    Nombre = TbxNombreCombo.Text,
                    Descripcion = TbxDescripcion.Text,
                    Imagen = "gg",
                    IDMembresia = (int)CbxMenbresias.SelectedValue
                };

                ComboProd_Transaction_BLL.AgregarEntidad(combo, productosAgregados);

                MessageBox.Show("Combo creado exitosamente.");

                ReiniciarProductosCBX();
                ObtenerProductosCBX();
                TbxPrecioCombo.Text = "0,00";
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_Combos_Leave(object sender, EventArgs e)
        {
            ReiniciarProductosCBX();
            TbxPrecioCombo.Text = "0,00";
            //Faltan la mayoria de las tbx's.
        }
    }
}
