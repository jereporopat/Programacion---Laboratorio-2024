using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A01___Calcular_un_factorial
{
    internal class CalcularFact
    {
        public static int factorial(int numero)
        {
            int factorial = 1;
            for (int i = numero; i > 0; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
