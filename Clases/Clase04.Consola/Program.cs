using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases04.Entidades;

namespace Clase04.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int lejajoAlumno2;
            long dniAlumno1;

            Alumno alumno1 = new Alumno("Juan", "Perez", 30865445);

            Alumno alumno2 = new Alumno("Jon", "Smith", 30865445,107645);

            lejajoAlumno2 = alumno2;
            dniAlumno1 = (long)alumno2;

            if (alumno1 + 102345)
            {
                Console.WriteLine("Se pudo realizar la suma! Valor del legajo: {0}", alumno1.GetLegajo());
            }
           
            Console.WriteLine("Legajo Alumno 2: {0}", lejajoAlumno2);

            Console.WriteLine("Dni Alumno 1: {0}", dniAlumno1);

            Console.WriteLine("Son iguales?: {0}\n", alumno1 == alumno2);
            Console.WriteLine("Son distintos?: {0}\n", alumno1 != alumno2);

            Console.ReadKey();

        }
    }
}
