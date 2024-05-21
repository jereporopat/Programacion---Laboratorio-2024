using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02___Atrapame_si_puedes
{
    public class Calculador
    {
        public static int Calcular(int entero1, int entero2)
        {
            if (entero2 == 0)
            {
                throw new DivideByZeroException($"ERROR: No se puede dividir por cero");
            }
            return entero1 / entero2;
        }
    }
}
