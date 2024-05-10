using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical:Aplicacion
    {
        private List<string> listaCanciones;

        protected override int Tamanio
        {
            get
            {
                int tamanioCanciones = listaCanciones.Count * 2;

                return tamanioMb + tamanioCanciones;
            }
        }
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanio)
        : this(nombre, sistemaOperativo, tamanio, null)
        {
        }
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanio, List<string> listaCanciones)
       : base(nombre, sistemaOperativo, tamanio)
        {
            if (listaCanciones is not null)
            {
                this.listaCanciones = listaCanciones;
            }
            else
            {
                this.listaCanciones = new List<string>();
            }
        }
        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine(base.ObtenerInformacionApp());

            foreach (string cancion in listaCanciones)
            {
                sb.AppendLine(cancion);
            }
            return sb.ToString();
        }
    }
}
