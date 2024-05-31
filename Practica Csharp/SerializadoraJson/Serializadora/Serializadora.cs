using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Serializadora
{
    public static class SerializadoraJson
    {
        static string ruta;

        static SerializadoraJson()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos-Serializacion2";
        }
        public static void Escribir(Mascota mascota)
        {
            string completa = ruta + @"\Serializadora_Mascota.json";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string objetoJson = JsonSerializer.Serialize(mascota);
                File.WriteAllText(completa, objetoJson);
            }
            catch (Exception e)
            {

                throw new Exception($"ERROR en el archivo {completa}");
            }
        }
        public static Mascota Leer()
        {
            string completa = ruta + @"\Serializadora_Mascota.json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string archivoJson = File.ReadAllText(completa);
                return JsonSerializer.Deserialize<Mascota>(archivoJson);
            }
            catch (Exception e)
            {
                throw new Exception($"ERROR en el archivo {completa}");
            }
        }
    }
}
