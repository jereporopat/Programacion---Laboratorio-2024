using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDC_El_viajar_es_un_placer
{
    internal class Automovil:VehiculoTerrestre
    {
        private int cantidadPasajeros;

        public Automovil (short cantidadR, short cantidadP, short cantidadM, Colores color, int cantidadPasajeros)
            : base(cantidadR, cantidadP, cantidadM, color)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
