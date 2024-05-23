using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Calculador
    {
        public static double Calcular(double kilometro, double litros)
        {
            if (litros == 0)
            {
                throw new DivideByZeroException("No puedes dividir por cero");
            }

            return kilometro / litros;
        }
    }
}
