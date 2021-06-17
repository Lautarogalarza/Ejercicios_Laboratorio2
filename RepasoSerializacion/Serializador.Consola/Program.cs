using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using serializadora.Entidades;

namespace Serializador.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona persona = new Persona("Esteban", "Prieto", 30);
            //Alumno alumno = new Alumno();
            ////Persona persona1 = new Persona("Lautaro", "Lautaro", 23);
            ////Persona persona2 = new Persona("Mauricio", "Cerizza", 30);

            Serializadora serializadora = new Serializadora();

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer("Jon", "Snow", 22, 100));
            customers.Add(new Customer("Ned", "Stark", 23, 101));
            customers.Add(new Customer("Bran", "Stark", 24, 102));
            customers.Add(new Customer("Arya", "Stark", 31, 103));
            customers.Add(new Customer("Tyrion", "Lannister", 25, 104));
            customers.Add(new Customer("Tywin", "Lannister", 26, 105));
            customers.Add(new Customer("Jaime", "Lannister", 27, 106));
            customers.Add(new Customer("Cersei", "Lannister", 28, 107));
            customers.Add(new Customer("Rhaegar ", "Targaryen", 29, 108));
            customers.Add(new Customer("Daenerys", "Targaryen", 30, 109));

            //////List<Persona> personas = new List<Persona>();

            //////personas.Add(persona);
            //////personas.Add(persona1);
            //////personas.Add(persona2);


            if (serializadora.Guardar(customers))
            {
                Console.WriteLine("Archivo Guardado exitosamente");
            }
            else
            {
                Console.WriteLine(serializadora.mensaje);
            }


            List<Customer> personasDeserializadas = serializadora.Leer();

            if (personasDeserializadas != null)
            {
                //Console.WriteLine(personasDeserializadas.Mostrar());

                //foreach (Persona item in personasDeserializadas)
                //{
                //    Console.WriteLine(item.Mostrar());
                //}
            }
            else
            {
                Console.WriteLine(serializadora.mensaje);
            }


            Console.ReadKey();

        }
    }
}
