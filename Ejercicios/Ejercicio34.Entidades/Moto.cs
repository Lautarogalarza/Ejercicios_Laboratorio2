using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34.Entidades
{
    public class Moto:VehiculoTerrestre
    {
        public short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, short cilindrada, Colores color):base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
