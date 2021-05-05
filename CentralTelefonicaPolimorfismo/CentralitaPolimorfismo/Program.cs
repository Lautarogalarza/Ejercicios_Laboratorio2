using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaPolimorfismo.Entidades;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita telefonica = new Centralita("MOVISTAR");

            Local local1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local local2 = new Local("Avellaneda", 45, "Lanus", 1.99f);
            Provincial provincial1 = new Provincial("Qulmes", Provincial.Franja.Franja_1, 21f, "Wilde");
            Provincial provincial2 = new Provincial(Provincial.Franja.Franja_3, provincial1);

            telefonica = telefonica + local1;
            telefonica = telefonica + local2;
            telefonica = telefonica + provincial1;
            telefonica = telefonica + provincial2;

            Console.WriteLine(telefonica.ToString());
            
            Console.WriteLine("////////////////////ORDENADOS///////////////////");
            telefonica.OrdenarLlamadas();
            Console.WriteLine(telefonica.ToString());
            Console.ReadKey();

        }
    }
}
