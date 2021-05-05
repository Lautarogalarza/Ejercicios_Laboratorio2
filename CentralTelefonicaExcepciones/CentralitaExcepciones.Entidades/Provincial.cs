using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaExcepciones.Entidades
{
    public class Provincial:Llamada
    {
       public enum Franja // creo los datos enumerados
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        #region ATRIBUTOS

        protected Franja franjaHoraria;

        #endregion

        #region CONSTRUCTORES


        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(origen, destino, duracion)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada unaLlamada) : this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {

        }

        #endregion

        #region METODOS

        private float CalcularCosto()
        {
            float costo = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = this.duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    costo = this.duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    costo = this.duracion * 0.66f;
                    break;
            }

            return costo;
        }

        #endregion

        #region POLIMORFISMO

        #region PROPIEDADES

        public override float CostoLLamada
        {
            get { return this.CalcularCosto(); }
        }


        #endregion

        #region SOBRECARGAS

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion

        #region METODOS

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Costo: " + this.CostoLLamada.ToString());
            sb.AppendLine(this.franjaHoraria.ToString());
            sb.AppendLine("Llamada Provincial");

            return sb.ToString();
        }

        #endregion


        #endregion

    }
}
