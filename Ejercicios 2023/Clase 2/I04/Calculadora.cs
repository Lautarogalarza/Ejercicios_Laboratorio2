using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I04
{
    public static class Calculadora
    {
        public static float Calcular(float primerOperando, float segundoOperando, string operacionMatematica)
        {
            float resultado = new();
            switch (operacionMatematica)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                    break;
                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;
                case "*":
                    resultado = primerOperando * segundoOperando;
                    break;
                case "/":
                    if (Calculadora.Validar(segundoOperando))
                    {
                        resultado = (float)primerOperando + segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("Error. El valor del dividendo debe ser mayor a 0, no se realizó la operación.");
                    }
                    break;
                default:
                    Console.WriteLine("Error. No ingreso un operador valido, no se realizó la operación.");
                    break;
            }
            return resultado;
        }

        private static bool Validar(float numero)
        {
            return numero > 0;
        }
    }
}
