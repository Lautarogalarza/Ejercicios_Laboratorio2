using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio42.Entidades
{
    public class MiException : Exception
    {
        public MiException(string mensaje, Exception inner) : base(mensaje, inner) 
        {
        }
    }
}
