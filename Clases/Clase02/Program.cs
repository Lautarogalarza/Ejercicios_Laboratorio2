using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {



            char character;
            Char.TryParse(Console.ReadLine(), out character);



            Console.WriteLine("\n" + character + "\n");


            Console.ReadKey();
        }
    }
}
