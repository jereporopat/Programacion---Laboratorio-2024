using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameGenerator.Generators;

namespace Entidades_Simulador_de_atención_a_clientes
{
    public class Negocio
    {
        private static RealNameGenerator nameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;

        static Negocio()
        {
            nameGenerator = new RealNameGenerator();
        }
        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas.ToList();
            clientes = new ConcurrentQueue<string>();
        }
        public List<Task> ComenzarAtencion()
        {
            var tasks = new List<Task>();

            // Iniciar la atención en todas las cajas
            foreach (var caja in cajas)
            {
                tasks.Add(caja.IniciarAtencion());
            }

            // Tarea de simulación de clientes
            var simulacionClientesTask = Task.Run(() =>
            {
                while (true)
                {
                    var nuevoCliente = nameGenerator.Generate();
                    clientes.Enqueue(nuevoCliente);
                    Thread.Sleep(1000);
                }
            });
            tasks.Add(simulacionClientesTask);

            // Tarea de asignación de cajas
            var asignacionCajasTask = Task.Run(() =>
            {
                while (true)
                {
                    if (clientes.TryDequeue(out var cliente))
                    {
                        if (!string.IsNullOrWhiteSpace(cliente))
                        {
                            var cajaConMenosClientes = cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();
                            cajaConMenosClientes.AgregarCliente(cliente);
                        }
                    }
                }
            });
            tasks.Add(asignacionCajasTask);

            return tasks;
        }
    }
}
