using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___Lanzar_y_atrapar
{
    public class MiClase
    {
        // Definición de las excepciones propias
        public class UnaExcepcion : Exception
        {
            public UnaExcepcion(string message, Exception innerException)
                : base(message, innerException) { }
        }

        public class MiExcepcion : Exception
        {
            public MiExcepcion(string message, Exception innerException)
                : base(message, innerException) { }
        }
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("Excepcion");
        }
        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Excepcion desde el primer constructor", ex);
            }
        }
        public MiClase(bool reintentar)
        {
            try
            {
                new MiClase();
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("MiExcepcion lanzada desde el segundo constructor", ex);
            }
        }

    }
}
