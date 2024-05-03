using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A02___La_veterinaria2
{
    public class Cliente
    {
        public string domicilio;
        public string nombre;
        public string apellido;
        public int telefono;
        public Mascota[] mascotas;

        public Cliente(string domicilio, string nombre, string apellido, int telefono, int cantMascotas)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mascotas = new Mascota[cantMascotas];
        }

        //public Cliente(string domicilio, string nombre, string apellido, int telefono, Mascota[] mascotas)
        //{
        //    this.domicilio = domicilio;
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.telefono = telefono;
        //    this.mascotas = mascotas;
        //}
    }
    public class Mascota
    {
        public string especie;
        public string nombre;
        public DateTime fechaNac;
        public string [] historialDeVacunacion;
        public int cantVacunas;

        public Mascota(string especie, string nombre,  DateTime fechaNac, int cantVacunas)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNac = fechaNac;
            this.cantVacunas = cantVacunas;
            historialDeVacunacion = new string[cantVacunas];
        }
       
    }
    public static class Mostrar
    {
        public static string MostrarCliente(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--------------------------------------");
            sb.AppendLine($"Domicilio del cliente: {cliente.domicilio}");
            sb.AppendLine($"Nombre del cliente: {cliente.nombre}");
            sb.AppendLine($"Apellido del cliente: {cliente.apellido}");
            sb.AppendLine($"Telefono: {cliente.telefono}");
            sb.AppendLine("--------------------------------------");
            foreach (var mascota in cliente.mascotas)
            {
                sb.AppendLine(MostrarMascota(mascota));
            }
            return sb.ToString();
        }
        public static string MostrarMascota(Mascota mascota)
        {
            StringBuilder sb =new StringBuilder();

            sb.AppendLine("--------------------------------------");
            sb.AppendLine($"Especie: {mascota.especie}");
            sb.AppendLine($"Nombre: {mascota.nombre}");
            sb.AppendLine($"Fecha de nacimiento: {mascota.fechaNac}");
            sb.AppendLine($"Historial de vacunacion: ");
            foreach (var vacuna in mascota.historialDeVacunacion)
            {
                if (!string.IsNullOrEmpty(vacuna))
                {
                    sb.AppendLine($"   - {vacuna}");
                }
            }
            sb.AppendLine("--------------------------------------");

            return sb.ToString();
        }
    }
}
