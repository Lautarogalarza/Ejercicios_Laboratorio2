using Entidades;
using System;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paloma paloma = new Paloma("Azir", "Shurima");
            Courier courier6 = new Courier("Vault", "Dweller", "33445566");
            Carta carta = new Carta("A4", 1);
            Email mail = new Email("jefe@gmail.com", "Programador@gmail.com");
            Cuervo cuervo = new Cuervo("Bloodraven");

            //Console.WriteLine(paloma.EnviarMensaje());
            //Console.WriteLine(courier6.EnviarMensaje());


            List<IMensaje> mensajes = new List<IMensaje>();

            mensajes.Add(mail);
            mensajes.Add(courier6);
            mensajes.Add(carta);
            mensajes.Add(cuervo);

            //Console.WriteLine("Implementacion explicita");

            //Console.WriteLine(((IEncriptado)cuervo).EnviarMensaje());

            //Console.WriteLine("Implementacion implicita");

            //Console.WriteLine(cuervo.EnviarMensaje());

            //ClasePrueba.Probar(mail);

            //foreach (IMensaje item in mensajes)
            //{
            //    Console.WriteLine(item.EnviarMensaje());
            //}

            ClasePrueba clasePrueba = new ClasePrueba();

            Courier courier = clasePrueba.MostrarPersona<Paloma>(paloma);

        }
    }
}
