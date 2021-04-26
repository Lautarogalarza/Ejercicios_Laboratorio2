using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11.Entidades
{
    public abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Dibujando Forma...";
        }

        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();

    }
}
