using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio_I01___Lanzar_y_atrapar.MiClase;

namespace Ejercicio_I01___Lanzar_y_atrapar
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {
            try
            {
                MiClase obj = new MiClase(true);
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion("Mi excepcion desde metodoInstancia", ex);
            }
        }
    }
}
