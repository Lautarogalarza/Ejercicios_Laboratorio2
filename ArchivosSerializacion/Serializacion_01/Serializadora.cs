using System.Xml.Serialization;

namespace Serializacion_01
{
    public static class Serializadora
    {
        static string ruta;

        static Serializadora()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos-Serializacion1";
        }

        public static void EscribirLista(List<Personaje> pjs)
        {
            string completa = ruta + @"\Serializadora_Lista.xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Personaje>));
                    xmlSerializer.Serialize(sw, pjs);
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
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

                using (StreamWriter sw = new StreamWriter(completa))
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
                    pj = xmlSerializer.Deserialize(sw) as Personaje;
                }

                return pj;

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static List<Personaje> LeerLista()
        {
            List<Personaje> pjs = null;
            string completa = ruta + @"\Serializadora_Lista.xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamReader sw = new StreamReader(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Personaje>));
                    pjs = xmlSerializer.Deserialize(sw) as List<Personaje>;
                }

                return pjs;

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

    }
}