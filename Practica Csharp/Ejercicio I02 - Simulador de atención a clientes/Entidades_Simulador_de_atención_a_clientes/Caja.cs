namespace Entidades_Simulador_de_atención_a_clientes
{
    public delegate void ClienteAtendidoDelegate(Caja caja, string cliente);
    public class Caja
    {
        private static Random random = new Random();
        private Queue<String> clientesALaEspera;
        private string nombreCaja;
        private ClienteAtendidoDelegate delegadoClienteAtendido;

        public string NombreCaja { get => nombreCaja; }

        public int CantidadDeClientesALaEspera => clientesALaEspera.Count;
        public Caja(string nombreCaja, ClienteAtendidoDelegate delegadoClienteAtendido)
        {
            this.nombreCaja = nombreCaja;
            clientesALaEspera = new Queue<String>();
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }
        internal void AgregarCliente(string cliente)
        {
            clientesALaEspera.Enqueue(cliente);
        }
        public Task IniciarAtencion()
        {
            return Task.Run(() =>
            {
                while (true)
                {
                    if (clientesALaEspera.Any())
                    {
                        if (clientesALaEspera.TryDequeue(out var cliente))
                        {
                            delegadoClienteAtendido(this, cliente);
                        }
                        Thread.Sleep(random.Next(1000, 5000));
                    }
                }
            });
        }
    }
}