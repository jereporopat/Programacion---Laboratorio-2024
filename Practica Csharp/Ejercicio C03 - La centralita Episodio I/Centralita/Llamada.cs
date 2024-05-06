using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {

        }
             
        public float GetDuracion()
        {
            return duracion;
        }
        public string GetNroDestino()
        {
            return nroDestino;
        }
        public string GetNroOrigen()
        {
            return nroOrigen;
        }



    }
}
