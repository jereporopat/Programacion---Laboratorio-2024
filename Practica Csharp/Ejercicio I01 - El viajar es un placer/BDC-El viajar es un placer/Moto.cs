using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDC_El_viajar_es_un_placer
{
    internal class Moto:VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadR, short cantidadP, Colores color, short cilindrada)
            : base(cantidadR, cantidadP, color)
        {

        }
}
}
