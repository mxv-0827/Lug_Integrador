using BE;
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
    public partial class UC_Salas : UserControl
    {
        public UC_Salas()
        {
            InitializeComponent();
        }

        //Salas
        Salas sala;

        //Salas y Asientos
        SalaAsiento_Transaction_BLL SalaAsiento_Transaction_BLL = new SalaAsiento_Transaction_BLL();

        private void BtnCrearSala_Click(object sender, EventArgs e)
        {
            try
            {
                sala = new Salas
                {
                    Nombre = TbxNombre.Text,
                    CapacidadTotal = int.Parse(TbxCapacidad.Text)
                };

                SalaAsiento_Transaction_BLL.CrearEntidades(sala);

                MessageBox.Show("Sala y asientos creados exitosamente.");
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
