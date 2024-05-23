using Aplicacion.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Helpers
{
    internal class Logger
    {
        public static void LogException(string log)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Logger.txt", true, Encoding.UTF8))
                {
                    sw.Write(log);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"No se puede grabar información", ex);
            }

        }
    }
}
