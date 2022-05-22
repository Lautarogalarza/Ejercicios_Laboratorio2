using System;
using System.Collections.Generic;

namespace SerializacionJson
{
    class Program
    {
        static void Main(string[] args)
        {

            Mascota mascota1 = new Mascota("Pepe", "Callejero", 9, false, true);

            List<Mascota> lista = new List<Mascota>()
            {
                    new Mascota("Juana", "Loba", 10, false, true),
                    new Mascota("Romeo", "Siames", 11, true, false),
                    new Mascota("Carmela", "Normal", 11, true, false)
            };


            ClaseSerializadoraJson<Mascota>.Escribir(mascota1, "mascota1");
            ClaseSerializadoraJson<List<Mascota>>.Escribir(lista, "lista");

            Mascota mascotaLeida = ClaseSerializadoraJson<Mascota>.Leer("mascota1");
            List<Mascota> listaMascotasLeidas = ClaseSerializadoraJson<List<Mascota>>.Leer("lista");

            Console.WriteLine("Info mascota Leida:" + mascotaLeida.ToString());
            Console.WriteLine();
            Console.WriteLine("Lista mascotas leidas");

            foreach (Mascota item in listaMascotasLeidas)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}
