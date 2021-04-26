using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Herencia.Entidades;

namespace Ejercicio_Herencia.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Catedra catedra = new Catedra();

            Alumno alumno1 = new Alumno("Lautaro", "Galarza", 113456, ETipoExamen.Primero);
            Alumno alumno2 = new Alumno("Esteban", "Prieto", 146445, ETipoExamen.Segundo);
            Alumno alumno3 = new Alumno("Ezequiel", "Oggioni", 107743, ETipoExamen.Final);
            Alumno alumno4 = new Alumno("Fede", "Davila", 103455, ETipoExamen.Segundo);
            Alumno alumno5 = new Alumno("Mauricio", "Cerizza", 123576, ETipoExamen.Final);

            AlumnoCalificado alumnoCalificad1 = new AlumnoCalificado(alumno4, 5);
            AlumnoCalificado alumnoCalificad2 = new AlumnoCalificado(alumno5, 6);

            if (catedra + alumno1 && catedra + alumno2 && catedra + alumno3 && catedra + alumnoCalificad1)
            {
                Console.WriteLine("Alumnos agregados correctamente!!\n\n");
            }

            catedra[5] = alumnoCalificad2;


            if (catedra == alumno1 )
            {
                Console.WriteLine("El alumno {0} se encuentra en la catedra\n\n", catedra[catedra | alumno1].GeApellido);
            }


            Console.WriteLine("---Alumnos---\n");

            catedra.GetAlumnos.Sort(Alumno.OrdenarPorLegajoDesc);

            foreach (Alumno item in catedra.GetAlumnos)
            {
                if (item is AlumnoCalificado)
                {
                    AlumnoCalificado alumno = (AlumnoCalificado)item;

                    Console.WriteLine(alumno.MostrarCalificado());
                }
                else
                {
                    Console.WriteLine(item.MostrarAlumno());
                }
            }

            Console.WriteLine("\nAlumno en el indice 3: {0}", catedra[3].MostrarAlumno());


            Console.ReadKey();

        }
    }
}
