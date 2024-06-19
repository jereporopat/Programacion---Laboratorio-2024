using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            // Obtener el nombre del usuario conectado
            string nombreUsuario = Environment.UserName;

            // Cambiar la propiedad Text del formulario
            this.Text = $"Compu de {nombreUsuario}";

            // Invocar al método para configurar el logo del sistema operativo
            ConfigurarLogoSistemaOperativo();

            // Obtener sistema operativo
            string sistemaOperativo = ObtenerDescripcionSistemaOperativo();

            // Asignar la descripción al label lblSistemaOperativo
            lblSistemaOperativo.Text = $"Sistema operativo: {sistemaOperativo}";

            //Obtener nombre de la maquina
            string nombreDeMaquina = Environment.MachineName;

            //Asignar a el label lblNombreMaquina
            lblNombreMaquina.Text = $"Nombre de la maquina: {nombreDeMaquina}";

            // Invocar al método para configurar la arquitectura
            ConfigurarArquitectura();

            //Obtener cantidad de procesadores
            int cantidadDeProcesadores = Environment.ProcessorCount;

            //Asignar a el label lblCantProcesadores
            lblCantProcesadores.Text = $"Cant. procesadores: {cantidadDeProcesadores}";

            // Obtener la ruta absoluta del directorio actual
            string directorioActual = Environment.CurrentDirectory;

            // Asignar el mensaje con el salto de línea y el directorio actual al label lblDirectorioActual
            lblDirectorioActual.Text = $"Identificación ejecutada en:{Environment.NewLine}{directorioActual}";

            // Invocar al método para configurar el espacio total y disponible
            ConfigurarEspacioTotalYDisponible();
        }
        private void ConfigurarLogoSistemaOperativo()
        {
            // Obtener la versión del sistema operativo
            OperatingSystem os = Environment.OSVersion;

            // Determinar el sistema operativo y asignar la imagen correspondiente
            if (os.Platform == PlatformID.MacOSX)
            {
                picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
            else if (os.Platform == PlatformID.Unix)
            {
                // Asumimos que Unix representa Linux, ya que no hay un PlatformID específico para Linux en .NET
                picboxSistemaOperativo.Image = Properties.Resources.linux;
            }
            else if (os.Platform == PlatformID.Win32NT)
            {
                picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
        }
        private string ObtenerDescripcionSistemaOperativo()
        {
            // Obtener la versión del sistema operativo
            OperatingSystem os = Environment.OSVersion;

            // Obtener la plataforma y la versión
            string plataforma = os.Platform.ToString();
            string version = os.Version.ToString();

            // Construir la descripción
            return $"{plataforma} {version}";
        }
        private void ConfigurarArquitectura()
        {
            // Determinar si el sistema es de 64 bits o 32 bits
            if (Environment.Is64BitOperatingSystem)
            {
                lblArquitectura.Text = "Arquitectura: 64 bits";
            }
            else
            {
                lblArquitectura.Text = "Arquitectura: 32 bits";
            }
        }
        private void ConfigurarEspacioTotalYDisponible()
        {
            // Obtener todas las unidades de almacenamiento
            DriveInfo[] drives = DriveInfo.GetDrives();

            long espacioTotal = 0;
            long espacioDisponible = 0;

            // Recorrer cada unidad y sumar el espacio total y disponible
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady) // Verificar que la unidad esté lista
                {
                    espacioTotal += drive.TotalSize;
                    espacioDisponible += drive.TotalFreeSpace;
                }
            }

            // Convertir los valores a gigabytes y redondear al entero más cercano
            long espacioTotalGB = (long)Math.Round(espacioTotal / (1024.0 * 1024 * 1024));
            long espacioDisponibleGB = (long)Math.Round(espacioDisponible / (1024.0 * 1024 * 1024));

            // Asignar los valores a los labels
            lblEspacioTotal.Text = $"Espacio total: {espacioTotalGB} Gigabytes";
            lblEspacioDisponible.Text = $"Espacio disponible: {espacioDisponibleGB} Gigabytes";
        }
    }
}
