using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo_Supervisorio;
using Entidades_supervisorio;

namespace Vizualizacao_Supervisorio
{
    static class Vizualizacao
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmEntrada());
            Application.Run(new frmLista());
        }
    }
}
