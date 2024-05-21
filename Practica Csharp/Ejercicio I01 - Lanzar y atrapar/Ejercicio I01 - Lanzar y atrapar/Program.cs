using Ejercicio_I01___Lanzar_y_atrapar;
using static Ejercicio_I01___Lanzar_y_atrapar.MiClase;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            OtraClase otraClase = new OtraClase();
            otraClase.MetodoInstancia();
        }
        catch (MiExcepcion ex)
        {
            Console.WriteLine("Excepción capturada en Main: " + ex.Message);
            Exception inner = ex.InnerException;
            while (inner != null)
            {
                Console.WriteLine("InnerException: " + inner.Message);
                inner = inner.InnerException;
            }
        }
    }
}