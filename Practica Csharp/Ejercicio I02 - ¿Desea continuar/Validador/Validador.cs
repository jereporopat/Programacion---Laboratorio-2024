using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validador
{
    public class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
