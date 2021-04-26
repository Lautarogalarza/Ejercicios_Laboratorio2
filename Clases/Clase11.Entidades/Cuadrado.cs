using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11.Entidades
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado( double alturaFigura):base(alturaFigura, alturaFigura)
        {

        }

        public override string Dibujar()
        {
            return "Dibujando Cuadrado...";
        }
        //public override double CalcularPerimetro()
        //{
        //    return this.baseFigura * 2 + this.alturaFigura * 2;
        //}

        //public override double CalcularSuperficie()
        //{
        //    return this.baseFigura * this.alturaFigura;
        //}

    }
}
