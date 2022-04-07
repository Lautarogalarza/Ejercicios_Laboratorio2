using System;

namespace Clase04
{
    public class Sobrecargadora
    {

        public static int Sumar(int operando1, int operando2)
        {
            return operando1 + operando2;
        }

        public static int Sumar(int operando1, int operando2, int operando3)
        {
            return ( Sumar(operando1, operando2) + operando3);
        }

        public static string Concatenar(string cadena1, string cadena2)
        {
            return $"Esta es la primer cadena {cadena1} y esta es la segunda {cadena2}";
        }

        public static string Concatenar(int numero, string cadena1, string cadena2)
        {
            return $"Esta es la primer cadena {cadena1} y esta es la segunda {cadena2}, le agregamos un numero {numero}";
        }


        public static string Mostrar(string nombre, string apellido, int edad = 1, string otroNombre = "")
        {
            return $"Nombre {nombre} Apellido {apellido} Edad {edad}";
        }


    }
}
