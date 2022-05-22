using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_01
{
    public static class Archivo
    {

        static string path;

        static Archivo()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-Serializacion\";
        }

        public static void Escribir(string datos)
        {
            string nombreArchivo = path + "Archivos_01_" + DateTime.Now.ToString("HH_mm_ss") + ".txt";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {

                    datos += "\nejemplo numero 1";
                    sw.WriteLine(datos);
                    sw.WriteLine("\n-----------------------------");
                    sw.WriteLine("\nlA FECHA ES: ");
                    sw.WriteLine(DateTime.Now.ToString());


                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }


        public static string Leer()
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            try
            {

                if (Directory.Exists(path))
                {
                    // recupera los nombres de los archivos que hay en esa carpeta incluida la ruta
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains("Archivos_01"))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {

                        using (StreamReader sr = new StreamReader(archivo))
                        {
                            string line;
                            // Lee y muestra lineas desde el archivo hasta el fin del mismo.

                            while ((line = sr.ReadLine()) != null)
                            {
                                informacionRecuperada += "\n" + line;
                            }

                        }
                    }
                }

                return informacionRecuperada;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }

    }
}
