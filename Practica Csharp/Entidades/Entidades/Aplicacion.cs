using System.Text;

namespace Entidades
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;


        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return sistemaOperativo;
            }
        }
        protected abstract int Tamanio { get; }

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        /// <summary>
        /// Recibe una lista de apps
        /// devuelve la instancia de la lista con mayor tamaño
        /// </summary>
        /// <param name="listaApp"></param>
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            Aplicacion appMasPesada = null;

            foreach (Aplicacion item in listaApp)
            {
                if (appMasPesada is null || item.Tamanio > appMasPesada.Tamanio)
                {
                    appMasPesada = item;
                }
            }
            return appMasPesada;
        }

        /// <summary>
        /// Retrona los datos de Aplicacion
        /// </summary>
        /// <returns></returns>
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Sistema operativo: {sistemaOperativo}");
            sb.AppendLine($"Tamaño ocupado: {Tamanio}");

            return sb.ToString();

        }
        /// <summary>
        /// retorna true si una aplicación existe en la lista recibida por parámetro comparando por su nombre
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (app is null || listaApp is null)
            {
                return false;
            }
            foreach (Aplicacion item in listaApp)
            {
                if (item.nombre == app.nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        /// <summary>
        /// añadirá una aplicación a la lista de aplicaciones pasada por parámetro
        /// siempre y cuando sea no exista previamente
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }
        /// <summary>
        /// devuelve nombre de la app
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return nombre;
        }
    }
}