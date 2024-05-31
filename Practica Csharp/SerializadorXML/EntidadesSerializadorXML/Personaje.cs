using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSerializadorXML
{
    public class Personaje
    {
        string nombre;
        int nivel;

        public Personaje()
        {
        }
        public Personaje(string nombre, int nivel)
        {
            this.Nombre = nombre;
            this.Nivel = nivel;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Nivel { get => nivel; set => nivel = value; }

        public override string ToString()
        {
            return $"Nombre: {nombre} - Nivel {nivel}";
        }
    }
}
