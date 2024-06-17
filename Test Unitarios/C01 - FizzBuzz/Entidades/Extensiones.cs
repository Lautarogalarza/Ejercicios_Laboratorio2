namespace Entidades
{
    public static class Extensiones
    {
        /*Reemplazar cualquier número divisible por tres con la palabra 
         * “Fizz” y cualquier número divisible por cinco con la palabra 
         * “Buzz”. Cualquier número divisible por ambos debe reemplazarse 
         * por "Fizz Buzz".*/
        public static string FizzBuzz(this int numero)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (numero % 5 == 0)
            {
                return "Buzz";
            }
            else if(numero % 3 == 0)
            {
                return "Fizz";
            }
            return numero.ToString();
        }
    }
}