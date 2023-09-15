namespace I07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;

            Console.WriteLine("Introduzca el valor X");
            x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el valor Y");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine($"El valor de r es:{Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))}");
        }
    }
}