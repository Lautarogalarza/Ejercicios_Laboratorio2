namespace I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int cantidadDivisores;
            bool esPrimo;
            do
            {
                Console.WriteLine("Ingrese un numero");
                respuesta = Console.ReadLine();
                if (respuesta == "salir")
                {
                    break;
                }
                if (int.TryParse(respuesta, out int numero))
                {
                    Console.WriteLine($"Los numeros primos hasta el numero {numero} son:");
                    for (int i = 1; i < numero; i++)
                    {
                        esPrimo = true;
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                esPrimo = false;
                                break;
                            }
                        }
                        if (esPrimo)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine($"Desea ingresar otro numero? s/n");
                    respuesta = Console.ReadLine();
                }
            } while (respuesta == "s");
        }
    }
}