using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionSB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenuPrincipal());
        }

        public static byte[] imageToByteArray(Image ImageIn)
        {
            var ms = new MemoryStream();
            ImageIn.Save(ms, ImageIn.RawFormat);

            return ms.ToArray();
        }
    }
}
