using System;
using System.Windows.Forms;
using Ferreteria;
namespace PVFP
{
    static class Program
    {      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new FrmInicioSesion());
        }
    }
}
