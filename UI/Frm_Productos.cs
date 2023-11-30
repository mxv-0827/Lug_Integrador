using BE;
using BE.Tabla_Intermedia;
using BLL;
using BLL.Entity_BLLs;
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
using UI.Extras;
using UI.FRM_CLIENTE;

namespace UI
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
        }

        public Usuarios Usuario { get; set; } //Sirve para llegar a establecer los descuentos.

        int locationX = 25, locationY = 122;
        private void CrearControlesProd(Productos producto)
        {
            Guna2Panel pnl = new Guna2Panel
            {
                Location = new Point(locationX, locationY),
                Size = new Size(200, 265),
                FillColor = Color.Black,
                BorderThickness = 1,
                BorderColor = Color.Black,
                Tag = producto
            };

            Guna2PictureBox pctbx = new Guna2PictureBox
            {
                Location = new Point(0, 42),
                Size = new Size(200, 181),
                Image = Imagen_Convertidor.HexaAImg(producto.Imagen),
                SizeMode = PictureBoxSizeMode.StretchImage,
                UseTransparentBackground = true
            };

            Guna2TextBox tbx1 = new Guna2TextBox
            {
                Location = new Point(0, 0),
                Text = producto.Nombre,
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Size = new Size(114, 36),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.Black,
                BorderThickness = 1,
                BorderColor = Color.Black,
            };

            Guna2TextBox tbx2 = new Guna2TextBox
            {
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Location = new Point(128, 0),
                Text = producto.Precio.ToString(),
                Size = new Size(72, 36),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.Black,
                BorderThickness = 1,
                BorderColor = Color.Black,
            };

            Guna2TextBox tbx3 = new Guna2TextBox
            {
                Location = new Point(0, 229),
                Text = producto.Dimension,
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Size = new Size(114, 36),
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.Black,
                ReadOnly = true,
                BorderThickness = 1,
                BorderColor = Color.Black,
            };

            Guna2NumericUpDown nup = new Guna2NumericUpDown
            {
                Location = new Point(128, 229),
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Size = new Size(72, 36),
                Cursor = Cursors.Hand,
                Maximum = producto.Stock,
                BorderThickness = 1,
                BorderColor = Color.Black,
            };

            pnl.Controls.Add(pctbx);
            pnl.Controls.Add(tbx1);
            pnl.Controls.Add(tbx2);
            pnl.Controls.Add(tbx3);
            pnl.Controls.Add(nup);

            this.Controls.Add(pnl);

            locationX += pnl.Size.Width + 71;

            if(locationX > 773)
            {
                locationX = 25;
                locationY += pnl.Size.Height + 30;
            }
        }


        private void CrearControlesComb(Combos combo)
        {
            Guna2Panel pnl = new Guna2Panel
            {
                Location = new Point(locationX, locationY),
                Size = new Size(200, 265),
                FillColor = Color.Black,
                BorderThickness = 1,
                BorderColor = Color.Black,
                Tag = combo
            };

            Guna2PictureBox pctbx = new Guna2PictureBox
            {
                Location = new Point(0, 42),
                Size = new Size(200, 181),
                Image = Imagen_Convertidor.HexaAImg(combo.Imagen),
                SizeMode = PictureBoxSizeMode.StretchImage,
                UseTransparentBackground = true
            };

            Guna2TextBox tbx1 = new Guna2TextBox
            {
                Location = new Point(0, 0),
                Text = combo.Nombre,
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Size = new Size(114, 36),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.Black,
                BorderThickness = 1,
                BorderColor = Color.Black,
            };

            Guna2TextBox tbx2 = new Guna2TextBox
            {
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Location = new Point(128, 0),
                Text = combo.Precio.ToString(),
                Size = new Size(72, 36),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.Black,
                BorderThickness = 1,
                BorderColor = Color.Black,
            };

            List<Productos> lstProds = new List<Productos>();
            DataTable tableProdEnComb = ProductosEnCombo_BLL.ObteneRegistrosPorIDCombo(combo.ID);

            foreach(DataRow row in tableProdEnComb.Rows)
            {
                Productos prod = (Productos)Base_BLL.ObtenerEntidadPorId("Productos", int.Parse(row["IDProducto"].ToString())).Rows[0];
                lstProds.Add(prod);
            }

            Guna2NumericUpDown nup = new Guna2NumericUpDown
            {
                Location = new Point(128, 229),
                Font = new Font("Segoe UI Black", 9f, FontStyle.Bold),
                Size = new Size(72, 36),
                Cursor = Cursors.Hand,
                BorderThickness = 1,
                BorderColor = Color.Black,
                Maximum = lstProds //Devuelve el stock mas chico de entre todos los productos que conforman al combo
                    .Min(row => row.Stock)
            };

            pnl.Controls.Add(pctbx);
            pnl.Controls.Add(tbx1);
            pnl.Controls.Add(tbx2);
            pnl.Controls.Add(nup);

            this.Controls.Add(pnl);

            locationX += pnl.Size.Width + 71;

            if (locationX > 773)
            {
                locationX = 25;
                locationY += pnl.Size.Height + 30;
            }
        }


        private void ObtenerListadoFiltrado()
        {
            DataTable tableProdFiltrada = new DataTable();
            DataTable tableComboFiltrada = new DataTable();

            tableProdFiltrada = tableProductos;
            tableComboFiltrada = tableCombos;

            if (CbxDimension.Text != "Todos") tableProdFiltrada = tableProductos.AsEnumerable().Where(row => row["Dimension"].ToString() == CbxDimension.Text).CopyToDataTable();
            if (CbxMembresia.Text != "Todos") tableComboFiltrada = tableCombos.AsEnumerable().Where(row => row["IDMembresia"].ToString() == CbxMembresia.SelectedValue.ToString()).CopyToDataTable();

            bool hayProd = false;
            if(CbxTipo.Text == "Producto" || CbxTipo.Text == "Todos")
            {
                foreach (DataRow row in tableProdFiltrada.Rows)
                {
                    Productos prod = (Productos)row;
                    CrearControlesProd(prod);
                }
                hayProd = true;
            }
            
            if(hayProd)
            {
                locationX = 25;
                locationY += 336;
            }
            
            if(CbxTipo.Text == "Combo" || CbxTipo.Text == "Todos")
            {
                foreach (DataRow row in tableComboFiltrada.Rows)
                {
                    Combos combo = (Combos)row;
                    CrearControlesComb(combo);
                }
            }
        }


        private void EliminarListado()
        {
            List<Guna2Panel> lstPaneles = this.Controls.OfType<Guna2Panel>().ToList();

            foreach(Guna2Panel pnl in lstPaneles)
            {
                this.Controls.Remove(pnl);
            }

            locationX = 25;
            locationY = 122;
        }


        DataTable tableProductos = new DataTable();
        DataTable tableCombos = new DataTable();

        Base_BLL Base_BLL = new Base_BLL();

        ProductosEnCombo_BLL ProductosEnCombo_BLL = new ProductosEnCombo_BLL();


        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            DataTable tableMembresias = Base_BLL.ObtenerTodasEntidades("Membresias");

            DataRow rowTodos = tableMembresias.NewRow();
            rowTodos["ID"] = 0;
            rowTodos["Nombre"] = "Todos";
            rowTodos["Descripcion"] = "";

            tableMembresias.Rows.InsertAt(rowTodos, 0);

            CbxMembresia.SelectedIndexChanged -= CbxMembresia_SelectedIndexChanged;
            CbxMembresia.DataSource = null;
            CbxMembresia.DataSource = tableMembresias;

            CbxMembresia.DisplayMember = "Nombre";
            CbxMembresia.ValueMember = "ID";

            CbxMembresia.SelectedIndex = 0;
            CbxMembresia.SelectedIndexChanged += CbxMembresia_SelectedIndexChanged;

            //-----------------------------------------------------------------------------------------------

            tableProductos = Base_BLL.ObtenerTodasEntidades("Productos");
            tableCombos = Base_BLL.ObtenerTodasEntidades("Combos");

            foreach (DataRow row in tableProductos.Rows)
            {
                Productos producto = (Productos)row;
                CrearControlesProd(producto);
            }

            locationX = 25;
            locationY += 336;

            foreach (DataRow row in tableCombos.Rows)
            {
                Combos combo = (Combos)row;
                CrearControlesComb(combo);
            }
        }

        

        private void CbxTIpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarListado();

            CbxMembresia.Enabled = true;
            CbxDimension.Enabled = true;

            if(CbxTipo.Text == "Producto")
            {
                CbxMembresia.Enabled = false;

                CbxMembresia.SelectedIndexChanged -= CbxMembresia_SelectedIndexChanged;
                CbxMembresia.SelectedIndex = 0;
                CbxMembresia.SelectedIndexChanged += CbxMembresia_SelectedIndexChanged;
            }

            else if(CbxTipo.Text == "Combo")
            {
                CbxDimension.Enabled = false;

                CbxDimension.SelectedIndexChanged -= CbxDimension_SelectedIndexChanged;
                CbxDimension.SelectedIndex = 0;
                CbxDimension.SelectedIndexChanged += CbxDimension_SelectedIndexChanged;
            }

            else
            {
                CbxMembresia.SelectedIndexChanged -= CbxMembresia_SelectedIndexChanged;
                CbxMembresia.SelectedIndex = 0;
                CbxMembresia.SelectedIndexChanged += CbxMembresia_SelectedIndexChanged;

                CbxDimension.SelectedIndexChanged -= CbxDimension_SelectedIndexChanged;
                CbxDimension.SelectedIndex = 0;
                CbxDimension.SelectedIndexChanged += CbxDimension_SelectedIndexChanged;
            }

            ObtenerListadoFiltrado();
        }

        

        private void CbxDimension_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarListado();
            CbxMembresia.Enabled = false;

            CbxTipo.SelectedIndexChanged -= CbxTIpo_SelectedIndexChanged;
            CbxTipo.SelectedIndex = 2;
            CbxTipo.SelectedIndexChanged += CbxTIpo_SelectedIndexChanged;

            ObtenerListadoFiltrado();
        }


        private void CbxMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarListado();
            CbxDimension.Enabled = false;

            CbxTipo.SelectedIndexChanged -= CbxTIpo_SelectedIndexChanged;
            CbxTipo.SelectedIndex = 1;
            CbxTipo.SelectedIndexChanged += CbxTIpo_SelectedIndexChanged;

            ObtenerListadoFiltrado();
        }


        private void BtnAgregarCarrito_Click(object sender, EventArgs e)
        {
            Frm_Compra frm = Application.OpenForms.OfType<Frm_Compra>().First();
            UC_HorarioPelicula uc = frm.Controls.OfType<UC_HorarioPelicula>().First();

            List<Guna2Panel> lstPaneles = this.Controls.OfType<Guna2Panel>().ToList();

            uc.LstCarrito.Clear();

            foreach(Guna2Panel pnl in lstPaneles)
            {
                Guna2NumericUpDown nup = pnl.Controls.OfType<Guna2NumericUpDown>().First();
                int descuentoUsuario = int.Parse(Base_BLL.ObtenerEntidadPorId("Membresias", Usuario.IDMembresia).Rows[0]["Descuento"].ToString());

                if(nup.Value > 0) //Osea, si el cliente decidio comprar aunque sea un producto o combo.
                {
                    Carrito carrito;

                    if (pnl.Tag is Productos prod)
                    {
                        carrito = new Carrito
                        {
                            IDCombo = null,
                            IDProducto = prod.ID,
                            Cantidad = (int)nup.Value,
                            Subtotal = Math.Round(prod.Precio * ((100 - (decimal)descuentoUsuario) / 100) * (int)nup.Value, 2)
                        };
                    }

                    else
                    {
                        Combos combo = (Combos)pnl.Tag;

                        carrito = new Carrito
                        {
                            IDCombo = combo.ID,
                            IDProducto = null,
                            Cantidad = (int)nup.Value,
                            Subtotal = Usuario.IDMembresia >= combo.IDMembresia ? Math.Round(combo.Precio * ((100 - (decimal)descuentoUsuario) / 100) * (int)nup.Value, 2) : combo.Precio * (int)nup.Value
                        };
                    }

                    uc.LstCarrito.Add(carrito);
                }
            }

            Close();
        }
    }
}
