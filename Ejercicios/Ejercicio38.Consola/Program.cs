using System;

namespace Ejercicio38y39.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio 38 y 39";

            SobreEscrito sobrecarga = new SobreEscrito();
            SobreSobreEscrito sobreSobrecarga = new SobreSobreEscrito();

            Console.WriteLine(sobrecarga.ToString());
            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());

            Console.WriteLine(sobreSobrecarga.MiMetodo());
            Console.WriteLine("----------------------------------------------");
            Console.ReadKey();

        }
    }
}
