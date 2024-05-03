using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0)
        {
        }
        public void Sumar (long num1, long num2)
        {
            cantidadSumas++;
            Console.WriteLine($"La suma de los valores numericos es de: {num1 + num2}");
        }
        public void Sumar (string cad1, string cad2)
        {
            cantidadSumas++;
            Console.WriteLine($"La concatenacion es: {cad1 + cad2}");
        }
        public static explicit operator int(Sumador sumador){
            return sumador.cantidadSumas;
        }
        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }
        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas;
        }
    }
}
