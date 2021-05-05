using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo.Entidades
{
    public class Local:Llamada
    {

        #region ATRIBUTOS

        protected float costo;

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
            return obj is Local;
        }

        #endregion

        #region METODOS

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Costo: " + this.costo.ToString("##.##"));
            sb.AppendLine("Llamada Local");

            return sb.ToString();
        }


        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion


        #endregion

        #region CONSTRUCTORES

        public Local(Llamada unaLlamada, float costo) : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo) : base(origen, destino, duracion)
        {
            this.costo = costo;
        }

        #endregion

        #region METODOS

        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        #endregion

    }
}
