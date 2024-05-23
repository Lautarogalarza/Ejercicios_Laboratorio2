using Entidades;
using System.Collections.Generic;

namespace Consola
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Paloma paloma = new Paloma("Azir", "Shurima");
            Courier courier6 = new Courier("Vault", "Dweller", "33445566");
            Carta carta = new Carta("Stark", "A4", 1);
            Email mail = new Email("jefe@gmail.com", "Programador@gmail.com");
            Cuervo cuervo = new Cuervo("Bloodraven");




            ClasePrueba clasePrueba = new ClasePrueba();

            clasePrueba.MostrarPersona<Paloma>(paloma);













            // Console.WriteLine(   ((IOculto)cuervo).EnviarMensaje()   );




            List<IMensaje> listMensaje = new List<IMensaje>();
            listMensaje.Add(cuervo);
            List<IOculto> listOculto = new List<IOculto>();
            listOculto.Add(cuervo);




            //Console.WriteLine(listMensaje[0].EnviarMensaje());
            //Console.WriteLine(listOculto[0].EnviarMensaje());




            //Console.WriteLine(ClasePrueba.Probar(mail));














            //Console.WriteLine(paloma.EnviarMensaje());
            //Console.WriteLine(carta.EnviarMensaje());

            //List<IMensaje> list = new List<IMensaje>(); 

            //list.Add(mail);
            //list.Add(carta);
            //list.Add(paloma);
            //list.Add(courier6);

            //foreach (IMensaje ma in list)
            //{
            //    Console.WriteLine(ma.EnviarMensaje());
            //}
        }
    }
}