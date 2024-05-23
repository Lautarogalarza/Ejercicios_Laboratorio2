using Entidades;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Class1.Metodo1();
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("******************************************************");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("******************************************************");
                Console.WriteLine(e.InnerException);
            }
        }
    }
}