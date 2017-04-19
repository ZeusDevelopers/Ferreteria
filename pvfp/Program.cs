using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //Application.Run(new FrmPuntoVenta_Buscar());
            //Application.Run(new Frmpuntodeventaporcentaje("uno",1));
            // Application.Run(new Frm_Consulta());
            //Application.Run(new FrmPerdida());
            ///Application.Run(new FrmEmpleados());
            //Application.Run(new FrmMenuAdmin()) ;
            //Application.Run(new FrmAltaProductos());
            ///Application.Run(new FrmMenuAdmin());
        }
    }
}
