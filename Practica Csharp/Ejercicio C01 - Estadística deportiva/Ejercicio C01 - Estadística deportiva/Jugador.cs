using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___Estadística_deportiva
{
    internal class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador( int partidosJugados, float promedioGoles, int totalGoles)
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador (int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public float GetPromedioGoles()
        {
            return promedioGoles;
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1 == j2;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Partidos Jugados: {partidosJugados}");
            sb.AppendLine($"Promedio de goles: {GetPromedioGoles()}");
            sb.AppendLine($"Total de goles: {totalGoles}");

            return sb.ToString();
        }
    }
}
