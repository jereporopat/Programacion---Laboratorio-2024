using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }
        public static bool InstalarApp (Aplicacion app)
        {
            if (app.SistemaOperativo != sistemaOperativo)
            {
                return false;
            }

            return appsInstaladas + app;
        }
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Sistema operativo: {sistemaOperativo}");

            foreach (Aplicacion app in appsInstaladas)
            {
                sb.AppendLine(app.ObtenerInformacionApp());
            }
            return sb.ToString();
        }
    }
}
