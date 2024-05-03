using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___Estadística_deportiva
{
    internal class Equipo
    {
        protected short cantidadDeJugadores;
        protected List<int> jugadores = new List<int>();
        protected string nombre;

        private Equipo(List<int> jugadores)
        {
            this.jugadores = jugadores;
        }
        public Equipo(short cantidadDeJugadores, string nombre)
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.cantidadDeJugadores >= e.cantidadDeJugadores || e.j.Contains(jugador))
            {
                Console.WriteLine("No se puede agregar el jugador al equipo.");
                return equipo;
            }
            equipo.jugadores.Add(jugador);
            return equipo;
        }
    }
}
