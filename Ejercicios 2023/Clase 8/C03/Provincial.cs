using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(float duracion, string nroDestino, string nroOrigen, Franja franja)
        : base(duracion, nroDestino, nroOrigen)
        {
            franjaHoraria = franja;
        }

        public Provincial(Franja franja, Llamada llamada)
        : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, franja) { }

        public float CostoLlamada { get { return CalcularCosto(); } }


        public string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine("Llamada Provincial");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo:{CostoLlamada}");
            sb.AppendLine($"Franja:{franjaHoraria}");

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float costo = 0;

            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    costo = duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    costo = duracion * 0.66f;
                    break;
                default:
                    break;
            }

            return costo;
        }
    }
}
