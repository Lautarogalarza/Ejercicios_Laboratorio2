using System;
using Clase04;

namespace Clase04.Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int resultado = Sobrecargadora.Sumar(5, 8);
            //int resultado2 = Sobrecargadora.Sumar(5, 8, 10);

            //Console.WriteLine(Sobrecargadora.Mostrar("Hola", "Mundo"));
            //Console.WriteLine(resultado);
            //Console.WriteLine(resultado2);


            Persona p1 = new Persona("Lautaro",DateTime.Now,11234567);

            Persona p2 = new Persona("Mauricio");

            Persona p3 = p1;

            Aula aula = new Aula();

            //if (p1 + aula)
            //{
            //    Console.WriteLine("Agregada");
            //}


            aula = aula + p2;

            aula += p1;

            Console.WriteLine(p1 == p2);

            long dni = p1;
            string nombre = (string)p1;

        }
    }
}
