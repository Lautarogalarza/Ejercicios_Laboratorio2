using System;
using Ejercicio53.Entidades;
namespace Ejercicio53.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio 53";

            bool retorno;

            Cartuchera1 cartuchera1 = new Cartuchera1();
            Cartuchera2 cartuchera2 = new Cartuchera2();

            Lapiz lapiz1 = new Lapiz(5);
            Lapiz lapiz2 = new Lapiz(1);
            Lapiz lapiz3 = new Lapiz(10);
            cartuchera2.lapices.Add(lapiz1);
            cartuchera2.lapices.Add(lapiz2);
            cartuchera2.lapices.Add(lapiz3);

            Boligrafo boligrafo1 = new Boligrafo(10, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(2, ConsoleColor.DarkGray);
            Boligrafo boligrafo3 = new Boligrafo(1, ConsoleColor.Magenta);
            cartuchera2.boligrafos.Add(boligrafo1);
            cartuchera2.boligrafos.Add(boligrafo2);
            cartuchera2.boligrafos.Add(boligrafo3);

            do
            {

                retorno = cartuchera2.ProbarElementos();
                Console.WriteLine(retorno);
            } while (retorno == true);
            Console.ReadKey();

        }
    }
}
