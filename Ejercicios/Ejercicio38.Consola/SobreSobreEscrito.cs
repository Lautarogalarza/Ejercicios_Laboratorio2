using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio38y39.Consola
{
    public class SobreSobreEscrito : SobreEscritoAbstracta
    {
        public override string miPropiedad 
        {
            get
            {
                return this.miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return this.miPropiedad;
        }
    }
}
