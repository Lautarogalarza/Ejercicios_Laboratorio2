using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio61.Entidades;

namespace Ejercicio61.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Lautaro", "Galarza");
            Persona p2 = new Persona("Esteban", "Prieto");
            Persona p3 = new Persona("Federico", "Davila");
            Persona p4 = new Persona("Mauricio", "Cerizza");
            Persona p5 = new Persona("Ezequiel", "Oggioni");

            try
            {
                //PersonaDao.Guardar(p1);
                //PersonaDao.Guardar(p2);
                //PersonaDao.Guardar(p3);
                //PersonaDao.Guardar(p4);
                //PersonaDao.Guardar(p5);

                //Persona p6 = PersonaDao.LeerPorId(3);

                //Console.WriteLine(p6.ToString());


                //PersonaDao.Eliminar(2);

                //List<Persona> personas = PersonaDao.Leer();

                //foreach (Persona item in personas)
                //{
                //    Console.WriteLine(item.ToString());
                //}

                Persona personaModificada = new Persona(3, "Esteban", "Prieto");
                PersonaDao.Modificar(personaModificada);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);           
            }

            Console.ReadLine();

        }
    }
}
