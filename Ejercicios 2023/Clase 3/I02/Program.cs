namespace I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Raiden", "17-12-1008", "34880745");
            Persona persona2 = new Persona("Kano", "05-04-2008", "51323897");
            Persona persona3 = new Persona("Sonya", "12-08-2012", "69430725");
            Persona persona4 = new Persona("Liu", "10-06-1978", "27142550");

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());
            Console.WriteLine(persona4.Mostrar());
            Console.WriteLine(persona4.EsMayorDeEdad());


            Console.ReadKey();
        }
    }
}