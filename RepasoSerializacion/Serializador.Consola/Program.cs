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
            Persona persona = new Persona("Esteban", "Prieto", 30);
            Alumno alumno = new Alumno();
            //Persona persona1 = new Persona("Lautaro", "Lautaro", 23);
            //Persona persona2 = new Persona("Mauricio", "Cerizza", 30);

            Serializadora serializadora = new Serializadora();

            //List<Persona> personas = new List<Persona>();

            //personas.Add(persona);
            //personas.Add(persona1);
            //personas.Add(persona2);


            if (serializadora.Guardar(alumno))
            {
                Console.WriteLine("Archivo Guardado exitosamente");
            }
            else
            {
                Console.WriteLine(serializadora.mensaje);
            }


            Persona personasDeserializadas = serializadora.Leer();

            if (personasDeserializadas != null)
            {
                Console.WriteLine(personasDeserializadas.Mostrar());

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
