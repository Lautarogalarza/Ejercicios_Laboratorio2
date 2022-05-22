using System;
using System.Collections.Generic;

namespace SerializacionXML_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquero arquerito = new Arquero("pepe arquero", 20, ETipoArco.ArcoFuego);
            Espadachin espadachincita = new Espadachin("Juana espadachina", 31, true);


            ClaseSerializadora<Arquero>.Escribir(arquerito,"arquero");
            ClaseSerializadora<Espadachin>.Escribir(espadachincita, "espadachina");

            List<Personaje> listaPersonajes = new List<Personaje>();
            listaPersonajes.Add(arquerito);
            listaPersonajes.Add(espadachincita);


            ClaseSerializadora<List<Personaje>>.Escribir(listaPersonajes,"lista");



            Arquero auxArquero = ClaseSerializadora<Arquero>.Leer("arquero");
            Espadachin auxEsparachin = ClaseSerializadora<Espadachin>.Leer("espadachina");


            List<Personaje> auxPersonajes = ClaseSerializadora<List<Personaje>>.Leer("lista");

            Console.WriteLine("Arquero deserializado:" + auxArquero.Nombre);
            Console.WriteLine("Espadachin deserializado:" + auxEsparachin.Nombre);
            Console.WriteLine("Lista deserializada:");

            foreach (Personaje item in auxPersonajes)
            {

                Console.WriteLine("Personaje deserializado:" + item.Nombre);
            }




        }
    }
}
