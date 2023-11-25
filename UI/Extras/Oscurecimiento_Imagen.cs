using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Extras
{
    internal static class Oscurecimiento_Imagen
    {
        internal static void OscurecerImagen(Guna2PictureBox pictureBox, float factor)
        {
            // Obtener la imagen original
            Image imagenOriginal = pictureBox.Image;

            // Crear una imagen con la misma dimensión y formato
            Bitmap imagenOscurecida = new Bitmap(imagenOriginal.Width, imagenOriginal.Height);

            // Crear un objeto Graphics para dibujar en la nueva imagen
            using (Graphics g = Graphics.FromImage(imagenOscurecida))
            {
                // Aplicar un filtro de color para oscurecer la imagen
                using (ImageAttributes atributos = new ImageAttributes())
                {
                    ColorMatrix matrizColor = new ColorMatrix
                    {
                        Matrix40 = -factor, // Ajusta el valor de brillo para oscurecer (-1 a 1)
                        Matrix41 = -factor,
                        Matrix42 = -factor
                    };
                    atributos.SetColorMatrix(matrizColor);

                    // Dibujar la imagen original en la nueva imagen con el filtro aplicado
                    g.DrawImage(imagenOriginal, new Rectangle(0, 0, imagenOriginal.Width, imagenOriginal.Height),
                        0, 0, imagenOriginal.Width, imagenOriginal.Height, GraphicsUnit.Pixel, atributos);
                }
            }

            // Establecer la imagen oscurecida en la Guna2PictureBox
            pictureBox.Image = imagenOscurecida;
        }

        internal static void RestaurarImagen(Guna2PictureBox pctbx)
        {
            pctbx.Image = pctbx.InitialImage;
        }
    }
}
