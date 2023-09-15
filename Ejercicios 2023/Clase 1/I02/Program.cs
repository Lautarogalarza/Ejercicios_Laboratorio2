namespace I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultadoCubo;
            double resultadoCuadrado;
            string valorIngresado;
            int numero;

            valorIngresado = Console.ReadLine();
            if (int.TryParse(valorIngresado, out numero))
            {
                Console.WriteLine("Pude convertir");
            }
            else
            {
                Console.WriteLine("No Pude convertir");
            }

            while (numero < 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.WriteLine("Ingrese un numero mayor a cero");
                valorIngresado = Console.ReadLine();


                if (int.TryParse(valorIngresado, out numero))
                {
                    Console.WriteLine("Pude convertir");
                }
                else
                {
                    Console.WriteLine("No Pude convertir");
                }
            }

            resultadoCuadrado = Math.Pow(numero, 2);
            resultadoCubo = Math.Pow(numero, 3);

            Console.WriteLine($"El resultado del cuadrado del numero {numero}, es {resultadoCuadrado}");
            Console.WriteLine($"El resultado del cubo del numero {numero}, es {resultadoCubo}");
        }
    }
}