using TorneoEntidades;

namespace Torneo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Copa chiqui tapia");

            EquipoFutbol e1 = new EquipoFutbol("El Defe", DateTime.Now);
            EquipoFutbol e2 = new EquipoFutbol("Lanu", DateTime.Now);

            _ = torneoFutbol + e1;
            _ = torneoFutbol + e2;


            Console.WriteLine(torneoFutbol.Mostrar());

            Console.WriteLine(torneoFutbol.JugarPartido);

        }
    }
}