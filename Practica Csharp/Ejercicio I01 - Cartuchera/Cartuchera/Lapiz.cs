using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartuchera
{
    public class Lapiz:IAcciones
    {
        private float tamanioMina;
        public Lapiz(float tamanioMina)
        {
            this.tamanioMina = tamanioMina;
        }

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return tamanioMina;
            }
            set
            {
                tamanioMina = value;
            }
        }
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            float minaConsumida = (float)(texto.Length * 0.3f);
            if (minaConsumida > tamanioMina)
            {
                minaConsumida = tamanioMina;
            }
            tamanioMina -= minaConsumida;
            return new EscrituraWrapper(ConsoleColor.Blue, texto);

        }
        public Lapiz (int unidades)
        {

        }


        public bool Recargar (int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Lápiz - Color: {Color}, Nivel de mina: {tamanioMina}";
        }
    }
}
