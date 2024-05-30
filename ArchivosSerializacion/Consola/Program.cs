using ArchivosUno;
using ArchivoDos;
using Serializacion_01;
using Serializacion_02;
using Serializacion_03;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ////StreamWriter
                //ArchivosUno.Archivo.Escribir("Laboratorio");
                //Console.WriteLine(ArchivosUno.Archivo.Leer());

                ////File
                //ArchivoDos.Archivo.Escribir();
                //Console.WriteLine(ArchivoDos.Archivo.Leer());



                //XML
                //Personaje pj1 = new Personaje("GorditoBondiola_", 10);
                //Personaje pj2 = new Personaje("Mondongo", 15);
                //Personaje pj3 = new Personaje("SuperPancho", 20);

                //List<Personaje> list = new List<Personaje>();

                //list.Add(pj1);
                //list.Add(pj2);
                //list.Add(pj3);

                //Serializadora.EscribirLista(list);

                //Console.WriteLine(Serializadora.Leer().ToString());

                //List<Personaje> personajes = Serializadora.LeerLista();

                //foreach (var item in personajes)
                //{
                //    Console.WriteLine(item.ToString());
                //}

                //Json
                //Mascota mascota1 = new Mascota("Moro", "Boxer", 9, true, true, new List<string>() { "Arroz", "Balanceado", "Carne" });
                //Mascota mascota2 = new Mascota("Pepe", "De la calle", 9, true, true, new List<string>() { "Arroz", "Corazon" });
                //Mascota mascota3 = new Mascota("Kira", "Gata", 9, true, false, new List<string>() { "Balanceado" });

                //List<Mascota> mascotas = new List<Mascota>();

                //mascotas.Add(mascota1);
                //mascotas.Add(mascota2);
                //mascotas.Add(mascota3);

                //SerializadoraJson<List<Mascota>>.Escribir(mascotas);

                //var mascotasDeserializadas = SerializadoraJson<List<Mascota>>.Leer();

                //foreach (var item in mascotasDeserializadas)
                //{
                //    Console.WriteLine(item.ToString());
                //}

                //XML Con herencia, no se puede hacer en JSON facilmente, no lo vamos a ver en la cursada
                Serializacion_03.Personaje pj1 = new Serializacion_03.Personaje("GorditoBondiola_", 10);
                Arquero pj2 = new Arquero("Mondongo", 15, true);
                Espadachin pj3 = new Espadachin("SuperPancho", 20, false);

                List<Serializacion_03.Personaje> list = new List<Serializacion_03.Personaje>();
                list.Add(pj1);
                list.Add(pj2);
                list.Add(pj3);

                Serializacion_03.Serializadora<List<Serializacion_03.Personaje>>.Escribir(list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}