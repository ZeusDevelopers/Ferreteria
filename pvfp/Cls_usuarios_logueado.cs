using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVFP
{
    class Cls_usuarios_logueado
    {
        private static string nombre = "";
        //se asigna el usuario desde el login 
        public static string usuario
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
