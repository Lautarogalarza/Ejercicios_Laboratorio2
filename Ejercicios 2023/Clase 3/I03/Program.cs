namespace I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante Juan = new Estudiante("Viazzo", "13609", "Juan");
            Estudiante Gonzalito = new Estudiante("Prats", "12050", "Gonzalo");
            Estudiante Brian = new Estudiante("Moreno", "12650", "Brian");


            Juan.NotaSegundoParcial = 8;
            Juan.NotaPrimerParcial = 9;
            Gonzalito.NotaSegundoParcial = 10;
            Gonzalito.NotaPrimerParcial = 7;
            Brian.NotaSegundoParcial = 2;
            Brian.NotaPrimerParcial = 4;

            Console.WriteLine(Juan.Mostrar());
            Console.WriteLine(Gonzalito.Mostrar());
            Console.WriteLine(Brian.Mostrar());

            Console.ReadKey();
        }
    }
}