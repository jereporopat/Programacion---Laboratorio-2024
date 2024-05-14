using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___Sobre_sobrescribiendo_esas_advertencias
{
    internal class Sobrescrito
    {
        public override string ToString()
        {
            return "Este es mi metodo ToString sobrecargado!" ;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()){
                return false ;
            }
            return true ;
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
