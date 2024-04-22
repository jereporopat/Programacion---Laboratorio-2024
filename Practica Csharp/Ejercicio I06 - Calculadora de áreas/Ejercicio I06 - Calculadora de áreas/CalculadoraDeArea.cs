using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I06___Calculadora_de_áreas
{
    internal class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double area;
            area = longitudLado * 2;

            return area;
        }
        public static double CalcularAreaTriangulo(double basee, double altura)
        {
            double area;
            area = basee * altura / 2;

            return area;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            double area;
            area = Math.PI * Math.Pow(radio, 2);

            return area;
        }
    }
}
