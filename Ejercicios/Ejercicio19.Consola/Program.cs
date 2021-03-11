using System;

namespace Ejercicio19.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio 19";

            int a = 0;
            int b = 0;

            Sumador s1 = new Sumador(5);

            Sumador s2 = new Sumador();

            Console.WriteLine(s1.Sumar(21,22));
            Console.WriteLine(s2.Sumar("Hello", "World"));

            a = (int)s1;
            b = (int)s2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(s1+s2);

            Console.WriteLine(s1|s2);

            Console.ReadLine();
 
        }
    }
}
