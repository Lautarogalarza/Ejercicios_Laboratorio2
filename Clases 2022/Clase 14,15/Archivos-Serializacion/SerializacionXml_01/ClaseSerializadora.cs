using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializacionXml_01
{
    public class ClaseSerializadora
    {

        static string path;

        static ClaseSerializadora()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-Serializacion\";
        }

        public static void Escribir(Personaje pj)
        {
            string nombreArchivo = path + "SerializacionXml_01_" + DateTime.Now.ToString("HH_mm_ss") + ".xml";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));
                    xmlSerializer.Serialize(streamWriter, pj);
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }


        public static Personaje Leer()
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            Personaje pj = null;
            try
            {

                if (Directory.Exists(path))
                {
                    // recupera los nombres de los archivos que hay en esa carpeta incluida la ruta
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains("SerializacionXml_01_"))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {

                        using (StreamReader sr = new StreamReader(archivo))
                        {

                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));
                            pj = (Personaje)xmlSerializer.Deserialize(sr);

                        }
                    }
                }

                return pj;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }



    }
}
