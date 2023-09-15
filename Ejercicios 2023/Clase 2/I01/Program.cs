namespace I01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroString;
            int min = int.MaxValue;
            int max = int.MinValue;
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                do
                {

                    Console.WriteLine("ingrese un numero");

                    numeroString = Console.ReadLine();

                } while (!int.TryParse(numeroString, out numero));


                if (Validador.Validar(numero, -100, 100))
                {
                    if (numero > max)
                    {
                        max = numero;
                    }
                    if (numero < min)
                    {
                        min = numero;
                    }
                    suma += numero;
                }
            }
        }
    }

}