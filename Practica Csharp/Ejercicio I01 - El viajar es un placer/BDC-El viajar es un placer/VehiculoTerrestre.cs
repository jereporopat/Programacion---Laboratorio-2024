using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BDC_El_viajar_es_un_placer
{
    public class VehiculoTerrestre
    {
        protected short camtidadRuedas;
        protected short cantidadPuertas;
        protected short cantidadMarchas;
        protected Colores color;

        public VehiculoTerrestre(short camtidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color)
        {
            this.camtidadRuedas = camtidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadMarchas = cantidadMarchas;
            this.color = color;
        }
    }
}
