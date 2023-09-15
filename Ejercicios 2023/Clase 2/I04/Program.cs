namespace I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            float primerNumeroIngresado = new();
            float segundoNumeroIngresado = new();
            float resultadoOperacion = new();
            string operadorOperacion;
            string respuesta;
            do
            {
                Console.WriteLine("Ingrese el primer numero a operar:");
                numeroIngresadoString = Console.ReadLine();
                if (float.TryParse(numeroIngresadoString, out primerNumeroIngresado))
                {
                    Console.WriteLine("Ingrese el primer numero a operar:");
                    numeroIngresadoString = Console.ReadLine();
                    if (float.TryParse(numeroIngresadoString, out segundoNumeroIngresado))
                    {
                        Console.WriteLine("Ingrese el operador (+,-,*,/) de la operación a realizar:");
                        operadorOperacion = Console.ReadLine();
                        if (operadorOperacion == "+" || operadorOperacion == "-" || operadorOperacion == "*" || operadorOperacion == "/")
                        {
                            resultadoOperacion = Calculadora.Calcular(primerNumeroIngresado, segundoNumeroIngresado, operadorOperacion);
                            Console.WriteLine($"El resultado de la operación {operadorOperacion} es: {resultadoOperacion}");

                        }
                        else
                        {
                            Console.WriteLine("Error. Debe ingresar un operador valido (+,-,*,/).");
                        }
                    }
                    else { Console.WriteLine("Error. Debe ingresar un valor valido."); }
                }
                else { Console.WriteLine("Error. Debe ingresar un valor valido."); }

                Console.WriteLine("Desea Continuar? <S/N>");
                 respuesta = Console.ReadLine().ToLower();

            } while (respuesta== "s");
        }
    }
}