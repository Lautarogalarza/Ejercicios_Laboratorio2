using Entidades;

namespace C01___FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 16; i++)
            {
                Console.WriteLine(i.FizzBuzz());
            }
        }
    }
}