using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppJuegos:Aplicacion
    {
        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb) 
            : base(nombre, sistemaOperativo, tamanioMb)
        {
        }

        protected override int Tamanio
        {
            get
            {
                return tamanioMb;
            }
        }
    }
}

