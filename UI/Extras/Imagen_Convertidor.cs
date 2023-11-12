using Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Extras
{
    public class Imagen_Convertidor
    {
        public static string ImgAHexa(string rutaImagen)
        {
            try
            {
                using (FileStream stream = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, (int)stream.Length);
                    return BitConverter.ToString(buffer).Replace("-", "");
                }
            }

            catch (Exception)
            {
                return "Fallo.";
            }
        }


        public static SvgDocument HexaASvg(string imgHexa)
        {
            byte[] bytes = Enumerable.Range(0, imgHexa.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(imgHexa.Substring(x, 2), 16))
                             .ToArray();

            // Convierte los bytes a una cadena SVG.
            string svgString = Encoding.UTF8.GetString(bytes);

            return SvgDocument.FromSvg<SvgDocument>(svgString);
        }
    }
}
