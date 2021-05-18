using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Interfaces.Entidades;

namespace Ejercicio_Interfaces.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Pesado paquetePesado = new Pesado(40,"11334455","Brazil","Argentina",1800,false);
            Fragil paqueteFragil = new Fragil(10, "BC-789544", "Chile", "Uruguay", 3600, true);

            GestionImpuestos gestionadora = new GestionImpuestos();

            gestionadora.recuadoImpuestosAfip.Add(paquetePesado);
            gestionadora.recuadoImpuestosAduana.Add(paquetePesado);
            gestionadora.recuadoImpuestosAduana.Add(paqueteFragil);

            Console.WriteLine(paquetePesado.InformacionPaquete());
            Console.WriteLine(paqueteFragil.InformacionPaquete());


            Console.WriteLine($"Recaudacion total Afip:{gestionadora.CalcularImpuestosTotalesAfip()}");
            Console.WriteLine($"Recaudacion total Aduana:{gestionadora.CalcularImpuestosTotalesAduana()}");



            Console.ReadLine();

        }
    }
}
