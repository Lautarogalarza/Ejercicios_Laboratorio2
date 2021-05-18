using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Interfaces.Entidades
{
    public abstract class Paquete
    {
        protected double peso;
        protected string codigoSeguimiento;
        protected string origen;
        protected string destino;
        protected double costoEnvio;
        public abstract bool Prioridad { get; }

        protected Paquete(double peso, string codigoSeguimiento, string origen, string destino,double costoEnvio)
        {
            this.peso = peso;
            this.codigoSeguimiento = codigoSeguimiento;
            this.origen = origen;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
        }

        public virtual string InformacionPaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Codigo: {0}\n", this.codigoSeguimiento);
            sb.AppendFormat("Peso: {0}kg\n", this.peso);
            sb.AppendFormat("Origen: {0}\n", this.origen);
            sb.AppendFormat("Destino: {0}", this.destino);

            return sb.ToString();
        }
    }
}
