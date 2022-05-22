using System;

namespace Archivos_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Archivo.Escribir("Ejemplo 1");

            string mensajeLeido = Archivo.Leer();

            Console.WriteLine(mensajeLeido);

        }
    }
}
