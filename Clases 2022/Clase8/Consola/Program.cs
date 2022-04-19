using System;
using System.Collections.Generic;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Lautaro", "Galarza", 22345555);
            Profesor prof = new Profesor("Mauricio", "Cerizza", 22345555,"Programacion II");
            Estudiante estudiante = new Estudiante("Lucas", "Rodriguez", 22345555, 123456);

            Persona p2 = prof;

            List<Persona> personas = new List<Persona>();

            personas.Add(p2);
            personas.Add(estudiante);
            personas.Add(p1);

            foreach (var item in personas)
            {
                if (item is Profesor profe)
                {
                    Console.WriteLine(profe.Corregir());
                }
                else if (item is Estudiante estudiante2)
                {
                    Console.WriteLine(estudiante2.Estudiar());
                }
            }

        }
    }
}
