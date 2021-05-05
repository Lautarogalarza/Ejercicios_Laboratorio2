using System;

namespace Ejercicio42.Entidades
{
    public class UnaExcepcion:Exception
    {
        public UnaExcepcion(string mensaje, Exception inner) : base(mensaje, inner) 
        { 

        }
    }
}
