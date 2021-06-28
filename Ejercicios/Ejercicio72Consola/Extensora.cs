using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio72Consola
{
    public static class Extensora
    {
        public static int ContadoraPuntuacion(this string cadena)
        {
            int cantidadDePuntuaciones = 0;
            int cantidadDePuntuaciones2 = 0;


            foreach (char item in cadena)
            {
                if (item == '.' || item == ';' || item == ',')
                {
                     cantidadDePuntuaciones++;
                }
            }

            cantidadDePuntuaciones2 = cadena.Count(c => (c == '.' || c== ';' || c == ','));

            return cantidadDePuntuaciones;
        }
    }
}
