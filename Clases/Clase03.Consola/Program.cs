using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase03.Entidades;

namespace Clase03.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente("Calle falsa 123", "Juan", "Perez", 1133457434);

            Mascota perro1 = new Mascota("firulais", "perro", new DateTime(2012,05,25));
            Mascota gato1 = new Mascota("pelusa", "gato", new DateTime(2020, 10, 12));
            Mascota gato2 = new Mascota("bola de nieve", "gato", new DateTime(2005, 04, 30));
            Mascota gato3 = new Mascota("bola de nieve2", "gato", new DateTime(2007,10,25));

            perro1.AddVacuna("sin vacunar");
            gato1.AddVacuna("triple felina");
            gato2.AddVacuna("anti rabia");

            cliente.AddMascota(perro1);
            cliente.AddMascota(gato1);
            cliente.AddMascota(gato2);
            cliente.AddMascota(gato3);

            Console.WriteLine(cliente.MostrarCliente());

            Console.ReadLine();

        }
    }
}
