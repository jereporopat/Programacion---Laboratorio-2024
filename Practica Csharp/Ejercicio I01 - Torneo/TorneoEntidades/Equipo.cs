using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoEntidades
{
    public abstract class Equipo
    {
        public string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }
        public static bool operator ==(Equipo a, Equipo b)
        {
            return a.nombre == b.nombre && a.fechaCreacion == b.fechaCreacion;
        }
        public static bool operator !=(Equipo a, Equipo b) { return !(a == b); }

        public string Ficha()
        {
            return $"{nombre} fundado el {fechaCreacion.ToString("dd/MM/yyyy")}";
        }
    }
}
