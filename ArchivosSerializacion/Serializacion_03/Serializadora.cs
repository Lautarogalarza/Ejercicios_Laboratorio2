using System.Xml.Serialization;

namespace Serializacion_03
{
    public static class Serializadora<T>
    {
        static string ruta;

        static Serializadora()
        {
            //ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"\Archivos-Serializacion3";
        }

        public static void Escribir(T pj)
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
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(sw, pj);
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }

        }
        public static T Leer()
        {
            //seteamos el valor a default en vez de null
            T pj = default;

            string completa = ruta + @"\Serializadora_.xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamReader sw = new StreamReader(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    //no se puede usar el as con generics
                    pj = (T)xmlSerializer.Deserialize(sw);
                }

                return pj;

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

    }
}