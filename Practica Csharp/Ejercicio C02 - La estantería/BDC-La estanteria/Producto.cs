using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDC_La_estanteria
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return precio;
        }
        public static string MostrarProducto(Producto producto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo: {producto.codigoDeBarra}");
            sb.AppendLine($"Marca: {producto.GetMarca()}");
            sb.AppendLine($"Precio: {producto.GetPrecio()}");

            return sb.ToString();
        }

        public static explicit operator string (Producto producto)
        {
            return producto.codigoDeBarra;
        }

        public static bool operator ==(Producto producto1, Producto producto2)
        {
            if (!(producto1 is null || producto2 is null))
            {
                return producto1.GetMarca() == producto2.GetMarca() && producto1.codigoDeBarra == producto2.codigoDeBarra;
            }
            return false;
        }
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 ==  producto2);
        }
        public static bool operator ==(Producto producto1, string cadena)
        {
            return producto1.GetMarca() == cadena;
        }
        public static bool operator !=(Producto producto1, string cadena)
        {
            return !(producto1 == cadena);
        }
    }
}
