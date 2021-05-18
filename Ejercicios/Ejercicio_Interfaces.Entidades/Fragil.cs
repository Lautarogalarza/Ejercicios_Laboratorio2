using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Interfaces.Entidades
{
    public class Fragil : Paquete,IAduana
    {
        private bool prioridad;
        public override bool Prioridad 
        { 
            get 
            {
                return this.prioridad;
            } 
        }

        public Fragil(double peso, string codigoSeguimiento, string origen, string destino, double costoEnvio, bool prioridad) : base(peso, codigoSeguimiento, origen, destino, costoEnvio)
        {
            this.prioridad = prioridad;
        }

        public override string InformacionPaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.InformacionPaquete());
            sb.AppendFormat("Prioridad: {0}\n",this.Prioridad ? "Alta" : "Baja");
            sb.AppendFormat("Impuesto Aduana: {0}$\n", this.CalcularImpuesto());


            return sb.ToString();
        }

        public double CalcularImpuesto()
        {
            return (this.costoEnvio * 0.35);
        }
    }
}
