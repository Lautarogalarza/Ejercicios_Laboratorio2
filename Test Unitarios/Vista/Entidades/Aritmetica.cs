using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Aritmetica
    {
                                                        //5000
        public static int CalcularPotencia(int numero, int exponente)
        {
            if(exponente < 0)
            {
                throw new ArgumentException("Solamente se aceptan exponentes mayores o iguales a 0");
            }
            int resultado = 1;
            for(int i = 0; i < exponente; i++) 
            {
                resultado *= numero;
            }
            return resultado;
        }
    }
}
