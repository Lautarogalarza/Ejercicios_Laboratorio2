using Entidades;

namespace I02___Contador_de_Digitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++) 
            { 
                Console.Write("Ingresa un numero: ");
                string aux = Console.ReadLine();
                if(long.TryParse(aux, out var numero))
                {
                    Console.WriteLine($"Cantidad de digitos: {numero.ContarCantidadDeDigitos()}");
                }
            }

        }
    }
}