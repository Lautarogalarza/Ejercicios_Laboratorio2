namespace Entidades
{
    public static class Extensiones
    {
        public static int ContarCantidadDeDigitos(this long numero)
        {
            //string aux = numero.ToString();
            //if (aux.Contains('-'))
            //{
            //    return aux.Length - 1;
            //}
            //return aux.Length;
            int contador = 0;
            do
            {
                contador++;
                numero /= 10;
            } while (numero != 0);
            return contador;
        }
    }
}