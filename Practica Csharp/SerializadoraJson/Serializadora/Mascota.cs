using System.Text;
namespace Serializadora
{
    public class Mascota
    {
        string nombre;
        string raza;
        int edad;
        bool peloCorto;
        bool esPerro;
        List<string> comidas;

        public Mascota(string nombre, string raza, int edad, bool peloCorto, bool esPerro, List<string> comidas)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Edad = edad;
            this.PeloCorto = peloCorto;
            this.EsPerro = esPerro;
            this.Comidas = comidas;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public int Edad { get => edad; set => edad = value; }
        public bool PeloCorto { get => peloCorto; set => peloCorto = value; }
        public bool EsPerro { get => esPerro; set => esPerro = value; }
        public List<string> Comidas { get => comidas; set => comidas = value; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Nombre: {nombre}");
            stringBuilder.AppendLine($"Raza: {raza}");
            stringBuilder.AppendLine($"Edad: {edad}");
            stringBuilder.AppendLine($"Tiene pelo corto: {peloCorto}");
            stringBuilder.AppendLine($"Es perro: {esPerro}");

            foreach (var item in comidas)
            {
                stringBuilder.AppendLine(item);
            }
            return stringBuilder.ToString();
        }
    }
}