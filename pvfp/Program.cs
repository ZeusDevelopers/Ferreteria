﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVFP
{
    static class Program
    {      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmAltaProductos());
            Application.Run(new FrmPuntoVenta());
            //Application.Run(new FrmPuntoVenta_final(9.8));
            //Application.Run(new FrmPuntoVenta_Buscar());
        }
    }
}
