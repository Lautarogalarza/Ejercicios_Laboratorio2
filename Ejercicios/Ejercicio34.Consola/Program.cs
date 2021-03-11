using System;
using Ejercicio34.Entidades;

namespace Ejercicio34.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 34";

            Camion camioncito = new Camion(8, 2, Colores.Azul, 8, 5000);
            Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}", camioncito.cantidadRuedas, camioncito.cantidadPuertas,camioncito.color,camioncito.cantidadMarchas,camioncito.pesoCarga);
            Console.WriteLine("--------------");
            Automovil autito = new Automovil(4, 5, Colores.Blanco, 5, 3);
            Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito.cantidadRuedas, autito.cantidadPuertas, autito.color, autito.cantidadMarchas, autito.cantidadPasajeros);
            Console.WriteLine("-----------");
            Moto motito = new Moto(2,0, 1000, Colores.Rojo);
            Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito.cantidadRuedas, motito.cantidadPuertas, motito.color, motito.cilindrada);
            Console.ReadKey();
        }
    }
}
