using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase09.Entidades;

namespace Clase09.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Persona> personas = new List<Persona>();

            Alumno alumnoPersona = new Alumno("Jon","Snow",4523333,134533);
            Profesor profesorPersona = new Profesor("Señor","Thompson",2345555,"Programacion");

            personas.Add(alumnoPersona);
            personas.Add(profesorPersona);


            foreach (Persona item in personas)
            {
                if (item is Alumno)
                {
                    Alumno alumno = (Alumno)item;

                    Console.WriteLine(alumno.MostrarAlumno());
                }
                else
                {
                    Profesor profesor = (Profesor)item;

                    Console.WriteLine(profesor.MostrarProfesor());
                }
            }

            Console.ReadKey();

        }
    }
}
