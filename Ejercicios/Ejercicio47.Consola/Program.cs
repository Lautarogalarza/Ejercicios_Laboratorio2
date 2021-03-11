using System;
using Ejercicio47.Entidades;

namespace Ejercicio47.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 47";

            Torneo<EquipoFutbol> torneoF = new Torneo<EquipoFutbol>("Torneo de futbol");
            Torneo<EquipoBasket> torneoB = new Torneo<EquipoBasket>("Torneo de basquet");

            DateTime fechaEq1 = new DateTime(2002, 08, 18);
            DateTime fechaEq2 = new DateTime(2010, 01, 01);
            DateTime fechaEq3 = new DateTime(2020, 10, 26);
            DateTime fechaEq4 = new DateTime(1977, 03, 05);
            DateTime fechaEq5 = new DateTime(1994, 06, 15);
            DateTime fechaEq6 = new DateTime(2018, 12, 22);

            EquipoFutbol eqFut1 = new EquipoFutbol("Manchester", fechaEq1);
            EquipoFutbol eqFut2 = new EquipoFutbol("Barcelona", fechaEq2);
            EquipoFutbol eqFut3 = new EquipoFutbol("Liverpool", fechaEq3);
            EquipoBasket eqBas1 = new EquipoBasket("Lakers", fechaEq4);
            EquipoBasket eqBas2 = new EquipoBasket("Bulls", fechaEq5);
            EquipoBasket eqBas3 = new EquipoBasket("Sixers", fechaEq6);

            torneoF += eqFut1;
            torneoF += eqFut2;
            torneoF += eqFut3;

            torneoB += eqBas1;
            torneoB += eqBas2;
            torneoB += eqBas3;

            Console.WriteLine(torneoF.Mostrar());
            Console.WriteLine(torneoB.Mostrar());

            Console.WriteLine(torneoF.JugarPartido);
            Console.WriteLine(torneoF.JugarPartido);
            Console.WriteLine(torneoF.JugarPartido);

            Console.WriteLine(torneoB.JugarPartido);
            Console.WriteLine(torneoB.JugarPartido);
            Console.WriteLine(torneoB.JugarPartido);

            Console.ReadLine();

        }
    }
}
