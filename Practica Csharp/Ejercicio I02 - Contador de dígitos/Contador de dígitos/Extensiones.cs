using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_dígitos
{
    public static class Extensiones
    {
        public static int ContarCantidadDeDigitos(this long numero)
        {
            string aux = numero.ToString();
            if (aux.Contains('-'))
            {
                return aux.Length - 1;
            }
            return aux.Length;
        }
    }
}
