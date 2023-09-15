using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I05
{
    public class Calculadora
    {
        public static bool EsNumero(string valorString, out int valor)
        {
            int auxiliar = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && int.TryParse(valorString, out auxiliar);
            valor = auxiliar;
            return retorno;
        }

        public static string ApredeteLasTablas(int numero)
        {
            StringBuilder sb = new();

            for (int i = 1; i < 10; i++)
            {
                sb.AppendLine($"{numero} x {i} = {numero * i}");
            }

            return sb.ToString();
        }
    }
}
