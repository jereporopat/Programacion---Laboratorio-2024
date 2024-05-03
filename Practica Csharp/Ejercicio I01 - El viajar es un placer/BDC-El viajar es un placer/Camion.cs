using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDC_El_viajar_es_un_placer
{
    internal class Camion : VehiculoTerrestre
    {
        private int pesoCarga;

        public Camion(short cantidadR, short cantidadP, short cantidadM, Colores color, int pesoCarga) 
            : base(cantidadR, cantidadP, cantidadM, color)
        {
            this.pesoCarga = pesoCarga;
        }
    }
}
