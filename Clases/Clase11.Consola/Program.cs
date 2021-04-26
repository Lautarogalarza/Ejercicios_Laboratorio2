using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase11.Entidades;

namespace Clase11.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            Cuadrado cuadrado = new Cuadrado(5);
            Circulo rectangulo = new Circulo(12);
            Rectangulo circulo = new Rectangulo(8,3);

            figuras.Add(cuadrado);
            figuras.Add(rectangulo);
            figuras.Add(circulo);

            foreach (Figura item in figuras)
            {
                Console.WriteLine("==================FIGURA {0}==============", figuras.IndexOf(item)+1);


                Console.WriteLine("Tipo: {0:0.00}", item.GetType());
                Console.WriteLine(item.Dibujar());
                Console.WriteLine("Area: {0:0.00}", item.CalcularSuperficie());
                Console.WriteLine("Perimetro: {0:0.00}", item.CalcularPerimetro());

                Console.WriteLine("========================================");
            }

            Console.ReadKey();

        }
    }
}
