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


        int locationX = 22, locationY = 87;
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
                FillColor = Color.DarkGray,
            };

            CterDisposicionAsientos.Controls.Add(tbx);

            locationX += 45;

            if (locationX > 202 && locationX < 351 && locationY <= 132) locationX = 351;

            else if (locationX > 531 && locationY < 132)
            {
                locationX = 22;
                locationY += 45;
            }

            else if (locationX > 531 && locationY == 132)
            {
                locationX = 67;
                locationY = 198;
            }

            else if (locationX == 292 && locationY == 198) locationX = 306;

            else if (locationX > 486 && locationY >= 198)
            {
                locationX = 67;
                locationY += 45;
            }
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

            locationX = 22;
            locationY = 87;
        }


        //Salas
        Salas sala;

        //Salas y Asientos
        SalaAsiento_Transaction_BLL SalaAsiento_Transaction_BLL = new SalaAsiento_Transaction_BLL();


        private void BtnCrearSala_Click(object sender, EventArgs e)
        {
            EliminarAsientosTBX();

            try
            {
                sala = new Salas
                {
                    Nombre = TbxNombre.Text,
                    CapacidadTotal = string.IsNullOrEmpty(TbxCapacidad.Text) ? 0 : int.Parse(TbxCapacidad.Text)
                };

                Generic_Validator<Salas>.ValidarPropiedades(sala);

                SalaAsiento_Transaction_BLL.CrearEntidades(sala);

                MessageBox.Show("Sala y asientos creados exitosamente.");

                for (int i = 0; i < int.Parse(TbxCapacidad.Text); i++)
                {
                    CrearGunaTBX(i + 1);
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
