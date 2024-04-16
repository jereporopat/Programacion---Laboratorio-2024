using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            if (numeroEntero == 0)
                return "0";

            string binario = "";
            while (numeroEntero > 0)
            {
                int residuo = numeroEntero % 2; // Calcula el residuo de dividir por 2
                binario = residuo.ToString() + binario; // Concatena el residuo al principio del número binario
                numeroEntero /= 2; // Divide el número por 2 para obtener el siguiente bit
            }

            return binario;
        }
        public static int ConvertirBinarioADecimal(string numeroEntero)
        {
            int decimalResult = 0;

            // Iterar a través de cada dígito del número binario
            for (int i = 0; i < numeroEntero.Length; i++)
            {
                // Convertir el dígito a un valor entero (0 o 1)
                int digito = numeroEntero[i] - '0';

                // Multiplicar el dígito por la potencia correspondiente de  2
                // y acumular el resultado en decimalResult
                decimalResult += digito * (int)Math.Pow(2, numeroEntero.Length - 1 - i);
            }

            return decimalResult;
        }

    }
}

