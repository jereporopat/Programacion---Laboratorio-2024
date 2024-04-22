using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaBibliotecaClases
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public Mascota[] Mascotas { get; set; }
        public int NumMascotas { get; set; }

        public Cliente(string nombre, string apellido, string domicilio, string telefono, int numMascotas)
        {
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Telefono = telefono;
            NumMascotas = numMascotas;
            Mascotas = new Mascota[numMascotas];
        }

        public override string ToString()
        {
            string infoCliente = $"Cliente: {Nombre} {Apellido}\nDomicilio: {Domicilio}\nTeléfono: {Telefono}\nMascotas:";
            foreach (var mascota in Mascotas)
            {
                infoCliente += $"\n{mascota}";
            }
            return infoCliente;
        }
    }

    public class Mascota
    {
        public string Especie { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string[] Vacunas { get; set; }
        public int NumVacunas { get; set; }

        public Mascota(string especie, string nombre, DateTime fechaNacimiento, int numVacunas)
        {
            Especie = especie;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            NumVacunas = numVacunas;
            Vacunas = new string[numVacunas];
        }

        public void AgregarVacuna(string vacuna)
        {
            Vacunas[NumVacunas++] = vacuna;
        }

        public override string ToString()
        {
            string infoMascota = $"  {Nombre} ({Especie}) - Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}\n  Historial de vacunación:";
            foreach (var vacuna in Vacunas)
            {
                if (!string.IsNullOrEmpty(vacuna))
                {
                    infoMascota += $"\n   - {vacuna}";
                }
            }
            return infoMascota;
        }
    }

}
