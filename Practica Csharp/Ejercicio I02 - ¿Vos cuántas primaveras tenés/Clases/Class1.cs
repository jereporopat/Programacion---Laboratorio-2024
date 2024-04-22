using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        string nombre;
        DateTime fechaDeNacimiento;
        string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        public void SetNombre (string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre() {return this.nombre;}
        public void SetFechaDeNacimiento (DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public DateTime GetFechaDeNacimiento() { return this.fechaDeNacimiento; }
        
        public void SetDni(string dni)
        {
            this.dni= dni;
        }
        public string GetDni() { return this.dni; }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaDeNacimiento.Year;

            return edad;
        }
        public string EsMayorDeEdad()
        {
            int edad = CalcularEdad();
            if (edad > 18)
            {
                return ("Es mayor de edad");
            }
            return ("Es menor de edad");
        }
        public static string Mostrar(Persona persona)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine ($"Nombre: {persona.nombre}");
            sb.AppendLine ($"Fecha de nacimiento: {persona.fechaDeNacimiento}");
            sb.AppendLine ($"DNI: {persona.dni}");
            sb.AppendLine($"Es mayor de edad?: {persona.EsMayorDeEdad()}");

            //sb.AppendLine($"Nombre: {persona.GetNombre()}");
            //sb.AppendLine($"Fecha de nacimiento: {persona.GetFechaDeNacimiento()}");
            //sb.AppendLine($"DNI: {persona.GetDni()}");

            return sb.ToString();
        }
    }
}
