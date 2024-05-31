using System.Xml.Serialization;
namespace EntidadesSerializadorXML

{
    public static class Serializadora
    {
        static string ruta;

        static Serializadora()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = @"\Archivos-SerializacionXML";
        }
        public static void Escribir(Personaje pj)
        {
            string completa = ruta + @"\Serializadora_.xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using(StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));
                    xmlSerializer.Serialize(sw, pj);
                }
            }
            catch (Exception e)
            {

                throw new Exception($"Error en el archivo {completa}");
            }
        }
        
        public static Personaje Leer()
        {
            Personaje pj = null;
            string completa = ruta + @"\Serializadora_.xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamReader sw = new StreamReader(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));
                    pj = (Personaje)xmlSerializer.Deserialize(sw);
                }
                return pj;
            }
            catch (Exception e)
            {
                throw new Exception($"ERROR en el archio {completa}");
            }

        }
    }
}