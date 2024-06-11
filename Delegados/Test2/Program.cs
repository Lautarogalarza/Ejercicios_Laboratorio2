namespace Test2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>()
            {
                100,281,148,129,324,271,38, -20, -7
            };

            string numeros = string.Empty;
            foreach (int numero in lista)
            {
                numeros += $"{numero} | ";
            }

            Console.WriteLine($"Numeros antes de filtrar {numeros}");

            // lista = lista.Filtrar(n => n < 0);
            lista = lista.Filtrar(n => n % 2 == 0);

            numeros = string.Empty;
            foreach (int numero in lista)
            {
                numeros += $"{numero} | ";
            }

            Console.WriteLine($"Numeros despues de filtrar {numeros}");
        }

        public static bool FiltrarNumerosPares(int numero)
        {
            return numero % 2 == 0;
        }
    }
}