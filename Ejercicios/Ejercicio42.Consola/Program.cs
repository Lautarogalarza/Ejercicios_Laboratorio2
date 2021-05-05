using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio42.Entidades;

namespace Ejercicio42.Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase oC = new OtraClase();
                oC.MetodoInstancia();
            }
            catch (MiException e)
            {
                Console.WriteLine(e.Message);

                Exception ex = e.InnerException;
                while (ex != null)
                {
                    Console.WriteLine(ex.Message);
                    ex = ex.InnerException;
                }
            }
            Console.ReadKey();
        }
    }
}
