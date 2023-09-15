using System.Text;

namespace I05
{
    public class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroIngresado;
            Console.WriteLine("Ingrese la tabla que quiere ver:");
            numeroIngresadoString = Console.ReadLine();
            if (Calculadora.EsNumero(numeroIngresadoString, out numeroIngresado))
            {
                Console.WriteLine($"Tabla de multiplicar del número {numeroIngresado}:");
                Console.WriteLine(Calculadora.ApredeteLasTablas(numeroIngresado));
            }
            else
            {
                Console.WriteLine("Error. Debe ingresar un numero valido.");
            }
        }
    }
}