using System;
using System.Collections.Generic;
using Entidades;

namespace ConexionConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //List<Persona> personas = PersonaAccesoDatos.Leer();

               // Persona persona = PersonaAccesoDatos.Leer(3);

                //foreach (Persona item in personas)
                //{
                //    Console.WriteLine(item.ToString());
                //}

               Persona personaAux = new Persona("Juanita");
                PersonaAccesoDatos.Guardar(personaAux.Nombre);


                //PersonaAccesoDatos.Modificar("Lautito",1);

               // PersonaAccesoDatos.Eliminar(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
