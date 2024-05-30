using Entidades;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Courier courier = new Courier("Vault", "Dweller", "33445566");
            Carta carta = new Carta("A4", 1, "Stark");
            Paloma paloma = new Paloma("Azir", "Shurima");
            Manejadora manejadora = new Manejadora();
            Email mail = new Email("jefe@gmail.com", "Programador@gmail.com");
            Cuervo cuervo = new Cuervo("Bloodraven");


            //Implementacion explicita
            Console.WriteLine(((IEncriptado)cuervo).EnviarMensaje());

            //Guardar implementacion en un tipo de dato IMensaje
            List<IMensaje> mensajes = new List<IMensaje>();
            IMensaje mensaje = courier;
            mensajes.Add(carta);
            mensajes.Add(courier);
            mensajes.Add(paloma);

            Console.WriteLine(mensaje.EnviarMensaje());


            foreach (var item in mensajes)
            {
                Console.WriteLine(item.EnviarMensaje());
            }


            //Inversion de control
            Console.WriteLine(manejadora.MostrarMensaje(courier));

            Console.WriteLine(courier.EnviarMensaje());
            Console.WriteLine(carta.EnviarMensaje());
            Console.WriteLine(paloma.EnviarMensaje());
        }
    }
}