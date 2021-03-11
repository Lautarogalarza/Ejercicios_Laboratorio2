using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34.Entidades
{
    public class Camion:VehiculoTerrestre
    {
        public int pesoCarga;
        public int cantidadMarchas;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga):base(cantidadRuedas,cantidadPuertas,color)
        {
            this.pesoCarga = pesoCarga;
            this.cantidadMarchas = cantidadMarchas;
        }
    }
}
