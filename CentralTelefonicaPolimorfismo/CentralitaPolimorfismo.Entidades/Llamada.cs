using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo.Entidades
{
    public abstract class Llamada
    {

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas

        }

        #region ATRIBUTOS

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion

        #region PROPIEDADES

        public abstract float CostoLLamada { get; } //PROPIEDAD ABSTRACTA SOLO SE DECLARA

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }

        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }

        }

        #endregion

        #region CONSTRUCTORS

        public Llamada(string origen, string destino, float duracion)
        {
            this.duracion = duracion;
            this.nroDestino = destino;
            this.nroOrigen = origen;

        }

        #endregion

        #region POLIMORFISMO

        protected virtual string Mostrar() //EL METODO ORIGINAL QUE VA A SER SOBRESCRITO EN SUS DERIVADOS
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Origen: " + this.nroOrigen);
            sb.AppendLine("Destino: " + this.nroDestino);
            sb.AppendLine("Duracion: " + this.duracion.ToString());

            return sb.ToString();

        }

        #endregion

        #region SOBRECARGAS

        public static bool operator ==(Llamada uno, Llamada dos)
        {

            bool retorno = false;

            if (Object.Equals(uno, null) == false && Object.Equals(dos, null) == false)
            {
                if (Local.Equals(uno, dos) || Provincial.Equals(uno, dos))
                {
                    if (uno.nroOrigen == dos.nroOrigen && uno.nroDestino == dos.nroDestino)
                    {
                        retorno = true;
                    }
                }

            }
            else
            {
                retorno = false;
            }

            return retorno;

        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }

        #endregion

        #region METODOS

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return String.Compare(uno.duracion.ToString(), dos.duracion.ToString());
        }


        #endregion

    }
}
