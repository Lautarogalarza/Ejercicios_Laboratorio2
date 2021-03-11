using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio73.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 73";

            string continuar = "s";
            long numero;

            while (continuar =="s")
            {
                do
                {
                    Console.Write("Ingrese un numero: ");

                } while (!long.TryParse(Console.ReadLine(),out numero));

                Console.WriteLine("Numero de\t" + numero.CantidadDeDigitos() + " digitos");

                Console.WriteLine("\nContinuar?: [s|n] ");
                continuar = Console.ReadLine();
            }
        }
    }
}
