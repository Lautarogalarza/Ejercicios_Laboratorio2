using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio73.Consola
{
    public static class Extensor
    {
        public static int CantidadDeDigitos(this long numero)
        {
            int cantidadDeDigitos = 0;

            foreach (char item in numero.ToString())
            {
                cantidadDeDigitos++;
            }

            return cantidadDeDigitos;
        }
    }
}
