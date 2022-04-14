using System;
using System.Collections.Generic;

namespace Clase06.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("12345", "Fiat", 2005);
            Auto auto2 = new Auto("124245", "ranault", 1998);
            Auto auto3 = new Auto("3445", "peugot", 2002);

            #region Arrays

            int[] numeros = new int[6];

            Auto[] autos = new Auto[2];

            autos[0] = auto1;

            numeros[0] = 1;
            numeros[1] = 10;
            numeros[2] = 14;
            numeros[3] = 7;
            numeros[4] = 20;
            numeros[5] = 45;


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            foreach (Auto item in autos)
            {
                Console.WriteLine(item.Patente);
            }

            #endregion

            #region Listas

            List<string> nombres = new List<string>();
            List<Auto> garage = new List<Auto>();
            List<int> listaNumeros = new List<int>();

            listaNumeros.Add(10);
            listaNumeros.Add(4);
            listaNumeros.Add(50);
            listaNumeros.Add(20);
            listaNumeros.Add(2);

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            listaNumeros.Sort(Comparacion);

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            nombres.Add("Lautaro");
            nombres.Add("Mauricio");
            nombres.Add("Lucas");


            garage.Add(auto1);
            garage.Add(auto2);
            garage.Add(auto3);


            garage.Sort(Comparacion);


            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }


            #endregion

            #region Diccionarios

            Dictionary<string, int> agenda = new Dictionary<string, int>();

            agenda.Add("Lautaro", 123456);
            agenda.Add("Mauricio", 145896);
            agenda.Add("Lucas", 7458624);

            foreach (KeyValuePair<string, int> item in agenda)
            {
                if (agenda.ContainsKey("Lucas"))
                {
                    Console.WriteLine("Lucas esta agendado");
                }

                if (agenda.ContainsValue(123456))
                {
                    Console.WriteLine("Exito");
                }
                Console.WriteLine($"Nombre {item.Key}  Numero {item.Value}");
            }


            if (agenda.TryGetValue("Lautaro",out int value))
            {
                Console.WriteLine(value);
            }

            #endregion

            #region Queue

            Queue<Auto> autosCola = new Queue<Auto>();

            autosCola.Enqueue(auto1);
            autosCola.Enqueue(auto2);
            autosCola.Enqueue(auto3);

            foreach (var item in autosCola)
            {
                Console.WriteLine(item.Mostrar());
            }

            Console.WriteLine(autosCola.Dequeue().Mostrar());

            foreach (var item in autosCola)
            {
                Console.WriteLine(item.Mostrar());
            }


            #endregion

            #region Stack

            Stack<Auto> autosPila = new Stack<Auto>();

            autosPila.Push(auto1);
            autosPila.Push(auto2);
            autosPila.Push(auto3);

            foreach (var item in autosPila)
            {
                Console.WriteLine(item.Mostrar());
            }

            Console.WriteLine(autosPila.Pop().Mostrar());

            foreach (var item in autosPila)
            {
                Console.WriteLine(item.Mostrar());
            }

            if (autosPila.Contains(auto1))
            {
                Console.WriteLine("Esta en la lista");
            }

            #endregion

        }

        public static int Comparacion(int a, int b)
        {
            return b - a;
        }

        public static int Comparacion(Auto a, Auto b)
        {
            return b.Modelo - a.Modelo;
        }


    }
}
