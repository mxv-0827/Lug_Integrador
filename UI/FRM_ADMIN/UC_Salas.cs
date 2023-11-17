using BE;
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
using UI.Validators;

namespace UI.FRM_ADMIN
{
    public partial class UC_Salas : UserControl
    {
        public UC_Salas()
        {
            InitializeComponent();
        }


        int locationX = 187, locationY = 71;
        private void CrearGunaTBX(int nroAsiento)
        {
            Guna2TextBox tbx = new Guna2TextBox
            {
                Location = new Point(locationX, locationY),
                Size = new Size(35, 35),
                Text = nroAsiento.ToString(),
                Name = $"TbxAsiento{nroAsiento}",
                TextAlign = HorizontalAlignment.Center,
                Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold),
                ForeColor = Color.Black,
                FillColor = Color.White,
                MinimumSize = new Size(35, 35),
            };

            CterDisposicionAsientos.Controls.Add(tbx);

            locationX += tbx.Size.Width + 10;

            if (locationX == 412 && (locationY == 71 || locationY == 161))
            {
                locationX = 97;
                locationY += tbx.Size.Height + 10;
            }

            else if (locationX == 502 && locationY == 116)
            {
                locationX = 187;
                locationY += tbx.Size.Height + 10;
            }

            else if (locationX == 277 && locationY == 206) locationX += tbx.Size.Width + 10;


            else if (locationX == 502 && locationY == 206)
            {
                locationX = 97;
                locationY += tbx.Size.Height + 10;
            }

            else if (locationY == 251) locationX += tbx.Size.Width + 10;
        }

        private void EliminarAsientosTBX()
        {
            List<Control> controlesAEliminar = new List<Control>();

            foreach (Control ctrl in CterDisposicionAsientos.Controls)
            {
                if (ctrl.Name.Length >= 10 && ctrl.Name.Substring(0, 10) == "TbxAsiento")
                {
                    controlesAEliminar.Add(ctrl);
                }
            }

            foreach (Control ctrlAEliminar in controlesAEliminar)
            {
                CterDisposicionAsientos.Controls.Remove(ctrlAEliminar);
            }

            locationX = 187;
            locationY = 71;
        }


        //Salas
        Salas sala;

        //Salas y Asientos
        SalaAsiento_Transaction_BLL SalaAsiento_Transaction_BLL = new SalaAsiento_Transaction_BLL();

        
        private void CbxCapacidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarAsientosTBX();

            for (int i = 0; i < int.Parse(CbxCapacidad.Text); i++)
            {
                CrearGunaTBX(i + 1);
            }
        }

        private void BtnCrearSala_Click(object sender, EventArgs e)
        {
            try
            {
                sala = new Salas
                {
                    Nombre = TbxNombre.Text,
                    CapacidadTotal = string.IsNullOrEmpty(CbxCapacidad.Text) ? 0 : int.Parse(CbxCapacidad.Text)
                };

                Generic_Validator<Salas>.ValidarPropiedades(sala);

                SalaAsiento_Transaction_BLL.CrearEntidades(sala);

                MessageBox.Show("Sala y asientos creados exitosamente.");

                EliminarAsientosTBX();

                CbxCapacidad.SelectedIndexChanged -= CbxCapacidad_SelectedIndexChanged;
                CbxCapacidad.SelectedIndex = -1;
                CbxCapacidad.SelectedIndexChanged += CbxCapacidad_SelectedIndexChanged;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
