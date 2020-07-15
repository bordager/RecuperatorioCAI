using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class Validaciones
    {
        public static string validartexto(string palabra)
        {
            int comprobacion = 0;
            if (int.TryParse(palabra, out comprobacion))
            {
                return "";
            }
            else
            {
                return palabra;
            }
        }
        public static int validarentero(string numero)
        {
            int comprobacion = 0;
            if (!int.TryParse(numero, out comprobacion))
            {
                return -1;
            }
            else
            {
                return comprobacion;
            }
        }
        public static double validardecimal(string numero)
        {
            double comprobacion = 0;
            if (!double.TryParse(numero, out comprobacion))
            {
                return -1;
            }
            else
            {
                return comprobacion;
            }
        }
    }
}
}
