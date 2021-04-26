using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11.Entidades
{
    public class Rectangulo : Figura
    {
        protected double baseFigura;
        protected double alturaFigura;

        public Rectangulo(double baseFigura, double alturaFigura)
        {
            this.baseFigura = baseFigura;
            this.alturaFigura = alturaFigura;
        }
        public override string Dibujar()
        {
            return "Dibujando Rectangulo...";
        }
        public override double CalcularPerimetro()
        {
            return this.baseFigura * 2 + this.alturaFigura * 2;
        }

        public override double CalcularSuperficie()
        {
            return this.baseFigura * this.alturaFigura;
        }
    }
}
