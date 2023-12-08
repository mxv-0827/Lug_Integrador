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
        public Timer timer;

        public UC_Home()
        {
            InitializeComponent();

            timer = new Timer()
            {
                Interval = 6000
            };

            timer.Tick += TmrCambioImg_Tick;
        }

        int i = 1;
        string[] rutasImgs = new string[]
        {
            "C:\\Users\\maxim\\Documents\\Maxi\\U.A.I\\6to CUATRIMESTRE\\LENGUAJES DE ULTIMA GENERACION\\FONDOS\\hall_cine.png",
            "C:\\Users\\maxim\\Documents\\Maxi\\U.A.I\\6to CUATRIMESTRE\\LENGUAJES DE ULTIMA GENERACION\\FONDOS\\hall_cine_2.png",
            "C:\\Users\\maxim\\Documents\\Maxi\\U.A.I\\6to CUATRIMESTRE\\LENGUAJES DE ULTIMA GENERACION\\FONDOS\\hall_pedidos.png",
            "C:\\Users\\maxim\\Documents\\Maxi\\U.A.I\\6to CUATRIMESTRE\\LENGUAJES DE ULTIMA GENERACION\\FONDOS\\sala_cine.png",
            "C:\\Users\\maxim\\Documents\\Maxi\\U.A.I\\6to CUATRIMESTRE\\LENGUAJES DE ULTIMA GENERACION\\FONDOS\\sala_cine_2.png",
        };

        private void UC_Home_Enter(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void TmrCambioImg_Tick(object sender, EventArgs e)
        {
            if (i > 4) i = 0;

            Bitmap bitmap = new Bitmap(rutasImgs[i]);
            PctbxImgRotativas.Image = bitmap;

            i++;
        }
    }
}
