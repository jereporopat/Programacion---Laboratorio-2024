namespace Cartuchera
{
    public class Boligrafo:IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get { return colorTinta; }
            set { colorTinta = value; }
        }
        public float UnidadesDeEscritura
        {
            get { return tinta; }
            set { tinta = value; }
        }
        public Boligrafo(int unidades, ConsoleColor color)
        {
            tinta = unidades;
            colorTinta = color;
        }
        public EscrituraWrapper Escribir(string texto)
        {
            float tintaConsumida = (float)(texto.Length * 0.3f);
            if (tintaConsumida > tinta)
            {
                tintaConsumida = tinta;
            }
            tinta -= tintaConsumida;
            return new EscrituraWrapper(ConsoleColor.Magenta, texto);
        }
        public bool Recargar(int unidades)
        {
            if (unidades > 0)
            {
                tinta += unidades;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Boligrafo - Color: Gris, Nivel de tinta: {tinta}"; 
        }
    }
}