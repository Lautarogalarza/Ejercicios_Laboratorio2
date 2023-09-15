namespace I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area de un cuadrado de lado 5: " + CalculadoraDeArea.CalculadoraCuadrado(5));
            Console.WriteLine("Area de un triangulo de base 2 y altura 3: " + CalculadoraDeArea.CalculoTriangulo(2, 5));
            Console.WriteLine("Area de un circulo de radio 3: " + CalculadoraDeArea.CalculoCirculo(3));
        }
    }

    public class CalculadoraDeArea
    {
        public static double CalculadoraCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double CalculoTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        public static double CalculoCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}