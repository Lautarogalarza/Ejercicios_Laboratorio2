using Herencia___Entidades;
using System.Collections;
using System.Collections.Generic;

namespace Herencia___Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Heroe heroe = new Heroe(100, 10, 50, "Mondongo");
            Mago mago = new Mago(100, 200, "Mondongo", 10, 50);
            Picaro picaro = new Picaro(100, 200, "Salchipapa", 10, 30);
            Tanque tanque = new Tanque(100, 200, "GorditoBondiola", 10, 70);
            Paladin paladin = new Paladin(100, 200, "Gordius", 10, 70, 60);
            Nigromante nigromante = new Nigromante(100, 200, "Pochoclo", 10, 70, 20);
            Arquero arquero = new Arquero(100, 200, "El Tulo", 10, 70, 60);

            //Console.WriteLine(Program.Mostrar(tanque));


            List<Heroe> party = new List<Heroe>
            {
                mago,
                picaro,
                tanque,
                paladin,
                nigromante,
                arquero
            };


            if (party.Contains(mago))
            {
                Console.WriteLine("El mago esta en la lista");
            }


            foreach (var item in party)
            {
                Console.WriteLine(item.Ataque_01());

                //    if (item is not null)
                //    {
                //        if (item is Arquero arqueroCast)
                //        {
                //            Console.WriteLine(arqueroCast.Ataque_03());
                //        }
                //        else if (item is Nigromante nigromanteCast)
                //        {
                //        }
                //        Console.WriteLine(nigromanteCast.Ataque_03());
                //        else if (item is Paladin paladinCast)
                //        {
                //            Console.WriteLine(paladinCast.Ataque_03());
                //        }
                //        else if (item is Mago magoCast)
                //        {
                //            Console.WriteLine(magoCast.Ataque_02());
                //        }
                //        else if (item is Tanque tanqueCast)
                //        {
                //            Console.WriteLine(tanqueCast.Ataque_02());
                //        }
                //        else if (item is Picaro picaroCast)
                //        {
                //            Console.WriteLine(picaroCast.Ataque_02());
                //        }
                //        else
                //        {
                //            Console.WriteLine(item.Ataque_01());
                //        }
                //    }
                //}





































































                //Console.WriteLine(heroe[Skills.LanzarArma]);
                //Console.WriteLine(heroe[Skills.Salto]);









                // Heroe[] party = new Heroe[7];
                // List<Heroe> heroes = new List<Heroe>();
                // ArrayList arrayList = new ArrayList();
                // List<string> nombres = new List<string>();
                // List<int> numeros = new List<int>();
                // Stack<int> numerosStack = new Stack<int>();
                // Queue<int> numerosQueue = new Queue<int>();
                // Dictionary<int,Heroe> valuePairs = new Dictionary<int, Heroe>();
                //// List<Dictionary<int,string>> listas = new List<Dictionary<int,string>>();

                // valuePairs.Add(1, mago);
                // valuePairs.Add(2, picaro);
                // valuePairs.Add(3, arquero);
                // valuePairs.Add(4, paladin);

                // Console.WriteLine(valuePairs.GetValueOrDefault(1).FichaHeroe());


                // numeros.Add(5);
                // numeros.Add(20);
                // numeros.Add(1);
                // numeros.Add(40);

                // numerosStack.Push(5);
                // numerosStack.Push(20);
                // numerosStack.Push(1);
                // numerosStack.Push(40);

                // numerosQueue.Enqueue(5);
                // numerosQueue.Enqueue(20);
                // numerosQueue.Enqueue(1);
                // numerosQueue.Enqueue(40);


                //Console.WriteLine(numerosStack.Pop());

                // Console.WriteLine(numerosQueue.Dequeue());






                //Console.WriteLine("Lista\n");
                //foreach (int i in numeros)
                //{
                //    Console.WriteLine(i);
                //}
                //Console.WriteLine("Pila\n");
                //foreach (int i in numerosStack)
                //{
                //    Console.WriteLine(i);
                //}
                //Console.WriteLine("Cola\n");
                //foreach (int i in numerosQueue)
                //{
                //    Console.WriteLine(i);
                //}





































                //nombres.Add("Lautaro");
                //nombres.Add("Gustavo");
                //nombres.Add("Anibal");
                //nombres.Add("Brenda");
                //foreach (var item in nombres)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.WriteLine();
                //foreach (var item in numeros)
                //{
                //    Console.WriteLine(item);

                //}
                //Console.WriteLine();

                //Console.WriteLine("Ordenadas\n");

                //numeros.Sort(Program.OrdenDescendente);
                //nombres.Sort(Program.OrdenDescendente);

                //foreach (var item in nombres)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.WriteLine();
                //foreach (var item in numeros)
                //{
                //    Console.WriteLine(item);
                //}

                //heroes.Add(heroe);
                //heroes.Add(mago);
                //heroes.Add(picaro);
                //heroes.Add(tanque);


                //heroes.Add(paladin);
                //heroes.Add(nigromante);
                //heroes.Add(arquero);


                //foreach (var item in party)
                //{
                //    if (item is not null)
                //    {
                //        if (item is Arquero arqueroCast)
                //        {
                //            Console.WriteLine(arqueroCast.Ataque_03());
                //        }
                //        else if (item is Nigromante nigromanteCast)
                //        {
                //            Console.WriteLine(nigromanteCast.Ataque_03());
                //        }
                //        else if (item is Paladin paladinCast)
                //        {
                //            Console.WriteLine(paladinCast.Ataque_03());
                //        }
                //        else if (item is Mago magoCast)
                //        {
                //            Console.WriteLine(magoCast.Ataque_02());
                //        }
                //        else if (item is Tanque tanqueCast)
                //        {
                //            Console.WriteLine(tanqueCast.Ataque_02());
                //        }
                //        else if (item is Picaro picaroCast)
                //        {
                //            Console.WriteLine(picaroCast.Ataque_02());
                //        }
                //        else
                //        {
                //            Console.WriteLine(item.Ataque_01());
                //        }
                //    }
                //}

            }

            //public static decimal Mostrar(Heroe heroe)
            //{
            //    return heroe.Vida;
            //}

            //public static int OrdenDescendente(int a, int b)
            //{
            //    return b - a;
            //}

            //public static int OrdenDescendente(string a, string b)
            //{
            //    return string.Compare(b, a);
        }
    }
}
