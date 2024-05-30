using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serializacion_02
{
    public static class SerializadoraJson<T>
    {
        static string ruta;

        static SerializadoraJson()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos-Serializacion2";
        }

        public static void Escribir(T item)
        {

            string completa = ruta + @"\Serializadora_Mascota.json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string objetoJson = JsonSerializer.Serialize(item);

                File.WriteAllText(completa, objetoJson);
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static T Leer()
        {
            string completa = ruta + @"\Serializadora_Mascota.json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }


                string archivoJson = File.ReadAllText(completa);

                return JsonSerializer.Deserialize<T>(archivoJson); ;

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }
    }
}