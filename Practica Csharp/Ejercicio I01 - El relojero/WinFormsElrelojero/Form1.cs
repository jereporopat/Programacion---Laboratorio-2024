namespace WinFormsElrelojero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Iniciar la actualización de la hora
            AsignarHora();
            // Iniciar el Timer
            timer1.Start();
            // Iniciar la actualización de la hora
            AsignarHora2();
        }

        public void AsignarHora()
        {
            // Crear un nuevo hilo para evitar bloquear la interfaz de usuario
            new Thread(() =>
            {
                while (true)
                {
                    // Invocar en el hilo principal para evitar errores de subprocesos cruzados
                    Invoke(new Action(() =>
                    {
                        lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    }));
                    // Esperar un segundo antes de la próxima actualización
                    Thread.Sleep(1000);
                }
            }).Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private async void AsignarHora2()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    // Invocar en el hilo principal para evitar errores de subprocesos cruzados
                    Invoke(new Action(() =>
                    {
                        lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    }));
                    // Esperar un segundo antes de la próxima actualización
                    Task.Delay(1000).Wait();
                }
            });
        }
    }
}