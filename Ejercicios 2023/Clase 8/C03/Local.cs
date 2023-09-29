using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03
{
    public class Local : Llamada
    {
        protected float costo;


        public Local(float duracion, string nroDestino, string nroOrigen, float costo) 
        : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        public float Costo { get { return CalcularCosto(); } }

        public Local(Llamada llamada, float costo)
        :this(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen,costo)
        {

        }

        public string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine("Llamada Local");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo:{Costo}");

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return costo * duracion;
        }
    }
}
