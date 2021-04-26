using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_18";

            Punto vert1 = new Punto(1, 3);
            Punto vert3 = new Punto(9, 8);

            Rectangulo rectangulo = new Rectangulo(vert1, vert3);

            Console.Write(Program.MostrarRectangulo(rectangulo));

            Console.ReadKey();
        }

        public static string MostrarRectangulo(Rectangulo rectangulo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Area Rectangulo: {0}\n", rectangulo.Area().ToString());
            sb.AppendFormat("Perimetro Rectangulo: {0}", rectangulo.Perimetro().ToString());

            return sb.ToString();
        }

    }
}
