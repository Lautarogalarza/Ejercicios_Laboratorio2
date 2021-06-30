using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoTXT : ILogs
    {
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Logger.txt";

        public bool Guardar()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
                {

                    sw.Write($"Se disfrutó el gol del siglo a las {DateTime.Now} hs \n");
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"No se puede grabar información en: ", ex);
            }
        }

        public string Leer()
        {
            string datos;

            try
            {
                using (StreamReader nuevoTexto = new StreamReader(path))
                {
                    datos = nuevoTexto.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                throw e;
            }

            return datos;
        }
    }
}
