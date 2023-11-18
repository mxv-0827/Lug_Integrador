using Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Extras
{
    public class Imagen_Convertidor
    {
        public static byte[] ImgAHexa(Image imagen)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                imagen.Save(stream, System.Drawing.Imaging.ImageFormat.Png); //Guarda las imagenes como PNG.
                return stream.GetBuffer();
            }
        }

        public static Image HexaAImg(byte[] imagenHexa)
        {
            using (MemoryStream stream = new MemoryStream(imagenHexa))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
