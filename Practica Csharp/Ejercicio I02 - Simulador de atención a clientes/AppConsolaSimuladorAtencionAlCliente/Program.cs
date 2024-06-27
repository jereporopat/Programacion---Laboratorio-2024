using Entidades_Simulador_de_atención_a_clientes;

class Program
{
    static void Main(string[] args)
    {
        // Instanciar el delegado con una expresión lambda
        ClienteAtendidoDelegate delegadoClienteAtendido = (caja, cliente) =>
        {
            string mensaje = $"[{DateTime.Now:HH:mm:ss}] - Hilo {Task.CurrentId} - {caja.NombreCaja} - Atendiendo a {cliente}. Quedan {caja.CantidadDeClientesALaEspera} clientes en esta caja.";
            Console.WriteLine(mensaje);
        };

            Caja caja1 = new Caja("Caja 01", delegadoClienteAtendido);
            Caja caja2 = new Caja("Caja 02", delegadoClienteAtendido);

            List<Caja> cajas = new List<Caja> { caja1, caja2 };

            Negocio negocio = new Negocio(cajas);

            Console.WriteLine("Asignando cajas...");

            // Llamar al método ComenzarAtencion de Negocio
            List<Task> tareas = negocio.ComenzarAtencion();

            // Utilizar el método estático WaitAll de Task
            Task.WaitAll(tareas.ToArray());
    } 
}