using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio38y39.Consola
{
    public abstract class SobreEscritoAbstracta
    {
        protected string miAtributo;

        public abstract string miPropiedad { get; }

        public SobreEscritoAbstracta()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public override string ToString()
        {
            return "Este es mi metodo ToString SobreEscrito!!";
        }

        public override bool Equals(object obj)
        {
            return obj is SobreEscrito;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }

        public abstract string MiMetodo();
    }
}
