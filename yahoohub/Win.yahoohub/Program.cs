using BL.yahoohub;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.yahoohub
{
    static class Program
    {
        public static Usuario usuario;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

        public static byte[] imageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, imageIn.RawFormat);

            return ms.ToArray();
        }

        public static byte[] imageToByteArray2(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, imageIn.RawFormat);

            return ms.ToArray();
        }

    }
}
