using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.FRM_CLIENTE
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        int i = 1;
        string[] rutasImgs = new string[]
        {
            "C:\\Users\\gvian\\OneDrive\\Documents\\Maxi\\MATERIAS CARRERA U.A.I\\6to CUATRIMESTRE\\LUG\\INTEGRADOR\\FONDOS\\hall_cine.png",
            "C:\\Users\\gvian\\OneDrive\\Documents\\Maxi\\MATERIAS CARRERA U.A.I\\6to CUATRIMESTRE\\LUG\\INTEGRADOR\\FONDOS\\hall_cine_2.png",
            "C:\\Users\\gvian\\OneDrive\\Documents\\Maxi\\MATERIAS CARRERA U.A.I\\6to CUATRIMESTRE\\LUG\\INTEGRADOR\\FONDOS\\hall_pedidos.png",
            "C:\\Users\\gvian\\OneDrive\\Documents\\Maxi\\MATERIAS CARRERA U.A.I\\6to CUATRIMESTRE\\LUG\\INTEGRADOR\\FONDOS\\sala_cine.png",
            "C:\\Users\\gvian\\OneDrive\\Documents\\Maxi\\MATERIAS CARRERA U.A.I\\6to CUATRIMESTRE\\LUG\\INTEGRADOR\\FONDOS\\sala_cine_2.png",
        };

        private void UC_Home_Enter(object sender, EventArgs e)
        {
            TmrCambioImg.Start();
        }

        private void TmrCambioImg_Tick(object sender, EventArgs e)
        {
            if (i > 4) i = 0;

            Bitmap bitmap = new Bitmap(rutasImgs[i]);
            PctbxImgRotativas.Image = bitmap;

            i++;
        }

        private void UC_Home_Leave(object sender, EventArgs e)
        {
            TmrCambioImg.Stop();
        }
    }
}
