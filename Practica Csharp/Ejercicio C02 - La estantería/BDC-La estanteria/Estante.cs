using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDC_La_estanteria
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion): this(capacidad)
        {
            ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicación del estante: {estante.ubicacionEstante}");
            sb.AppendLine("Productos en el estante:");

            foreach (Producto producto in estante.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(producto));
            }
            return sb.ToString();
        }
        public static bool operator ==(Estante estante, Producto producto)
        {
            foreach (Producto p in estante.productos)
            {
                if (p == producto)
                {
                    return true;
                }
            }return false;
        }
        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }
        public static bool operator +(Estante estante, Producto producto)
        {
            if (estante == producto)
            {
                return false;
            }
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] is null)
                {
                    estante.productos[i] = producto;
                    return true; // Producto agregado
                }
            }
            return false; // No hay espacio
        }
        public static Estante operator -(Estante estante, Producto producto)
        {
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] == producto)
                {
                    estante.productos[i] = null;
                }
            }
            return estante;
        }
    }
}
