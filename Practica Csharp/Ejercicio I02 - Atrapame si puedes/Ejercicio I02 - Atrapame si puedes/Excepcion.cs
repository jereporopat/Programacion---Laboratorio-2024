using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02___Atrapame_si_puedes
{
    public class ParametrosVacios:Exception
    {
        public ParametrosVacios (string mensaje) : base(mensaje) { }
    }
}
