using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    internal class Provincial:Llamada
    {
        private Franja franjaHoraria;

        public float GetCostoLlamada()
        {

        }
        private float CalcularCosto()
        {
            return valorDeLlamada = duracion * costo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");

            return sb.ToString();
        }

    }
}
