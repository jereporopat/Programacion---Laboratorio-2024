using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cuenta
    {
        public string titular;
        public decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public void SetTitular(string titular)
        {
            this.titular = titular;
        }
        public string GetNombre() { return this.titular; }

        public void SetCantidad(decimal cantidad)
        {
            this.cantidad = cantidad;
        }
        public decimal GetCantidad() { return this.cantidad; }

        public static string Mostrar(Cuenta cuenta)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--------------------------------------");
            sb.AppendLine($"Datos de la cuenta: ");
            sb.AppendLine($"El nombre del titular es: {cuenta.GetNombre()}");
            sb.AppendLine($"Cantidad de dinero en cuenta: {cuenta.GetCantidad()}");
            sb.AppendLine("--------------------------------------");

            return sb.ToString();
        }
        public void Ingresar(decimal monto)
        {

            if (monto > 0)
            {
                this.cantidad += monto;
            }
        }
        public void Retirar(decimal monto)
        {
            cantidad -= monto;
        }
    }
}
