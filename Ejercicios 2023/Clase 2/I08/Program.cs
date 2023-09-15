namespace I08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fechaIngresadaString;
            DateTime fechaIngresada;
            int diasPasados;
            do
            {
                Console.WriteLine("Ingrese una fecha (dd/mm/aa):");
                fechaIngresadaString = Console.ReadLine();
                if (DateTime.TryParse(fechaIngresadaString, out fechaIngresada))
                {
                    diasPasados = Calculadora.CalcularDías(fechaIngresada);
                    Console.WriteLine($"Desde la fecha ingresada pasaron {diasPasados} días.");
                }
                else
                {
                    Console.WriteLine("Error. Ingrese una fecha válida");
                    Console.WriteLine("Formato: dd/mm/aaaa (día/mes/año)");
                }

            } while (fechaIngresada.Year == 0001);
        }
    }
}