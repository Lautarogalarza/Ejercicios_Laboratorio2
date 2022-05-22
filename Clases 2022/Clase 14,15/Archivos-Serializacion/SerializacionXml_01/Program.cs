using System;

namespace SerializacionXml_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Personaje pj = new Personaje("Pepe", 10);

            ClaseSerializadora.Escribir(pj);

            Personaje aux = ClaseSerializadora.Leer();

            Console.WriteLine(aux.ToString());



        }
    }
}
