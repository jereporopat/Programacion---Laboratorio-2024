using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    internal class Local:Llamada
    {
        protected float costo;

        public Local (Llamada llamada, float costo)
        {
            this.costo = costo;
        }
        public Local (float duracion, string destino, string origen , float costo)
            : base (duracion, nroDestino, nroOrigen)
        {

        }

        public float GetCostoLlamada()
        {
            return costo;
        }
        private float CalcularCosto()
        {
            return 
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");

            return sb.ToString();
        }
    }
}
