using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
   public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = vertice1;
            this.vertice4 = vertice3;

        }

        public float Area()
        {
            int baseR;
            int alturaR;

            if (this.area == 0)
            {
                baseR = (Math.Abs(vertice1.GetX() - vertice3.GetX()));
                alturaR = (Math.Abs(vertice1.GetY() - vertice3.GetY()));
                this.area = baseR * alturaR;
            }

            return this.area;
        }

        public float Perimetro()
        {
            int baseR;
            int alturaR;

            if (this.perimetro == 0)
            {
                baseR = (Math.Abs(vertice1.GetX() - vertice3.GetX()));
                alturaR = (Math.Abs(vertice1.GetY() - vertice3.GetY()));
                this.perimetro = (baseR + alturaR) * 2;
            }

            return this.perimetro;
        }
    }
}
