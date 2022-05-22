using System;

namespace Archivos_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Archivo.Escribir("Hola mundo");


            string mensajeLeido = Archivo.Leer();

            Console.WriteLine(mensajeLeido);



        }
    }
}
