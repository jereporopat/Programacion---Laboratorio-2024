using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public static int Calcular(int numero1, int numero2, string operador)
        {
            int resultado = 0;

            if (operador == "+")
            {
                resultado = numero1 + numero2;
            }
            if (operador == "-")
            {
                resultado = numero1 - numero2;
            }
            if (operador == "*")
            {
                resultado = numero1 * numero2;
            }
            if (operador == "/")
            {
                if (Validar(numero2))
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    resultado = -1;
                }
            }
            return resultado;

        }
        private static bool Validar(int numero2)
        {
            if (numero2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
