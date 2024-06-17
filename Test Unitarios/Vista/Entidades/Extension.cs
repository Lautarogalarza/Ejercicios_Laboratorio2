using System.Runtime.CompilerServices;

namespace Entidades
{
    public static class Extension
    {
        public static int ContarPalabras(this string texto)
        {
            return texto.Split(' ').Length;
        }

        public static bool EsPar(this int numero, bool algo)
        {
            return numero % 2 == 0;
        }
    }
}