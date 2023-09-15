using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I08
{
    public class Calculadora
    {
        public static int CalcularDías(DateTime fecha)
        {
            TimeSpan diasPasados;
            DateTime fechaActual = DateTime.Now;
            diasPasados = fechaActual.Subtract(fecha);
            int retorno = diasPasados.Days;
            return retorno;
        }
    }
}
