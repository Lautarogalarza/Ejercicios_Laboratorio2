using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio48.Entidades;

namespace Ejercicio48.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> nuevaContabilidad = new Contabilidad<Factura, Recibo>();

            Recibo r1 = new Recibo(21);
            Recibo r2 = new Recibo();
            Factura f1 = new Factura(53);
            Factura f2 = new Factura(12);

            nuevaContabilidad += f1;
            nuevaContabilidad += f2;
            nuevaContabilidad += r1;
            nuevaContabilidad += r2;

            Console.WriteLine(nuevaContabilidad.ToString());

            Console.ReadLine();
        }
    }
}
