using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaExcepciones.Entidades
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }


        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {

        }
        public CentralitaException(string mensaje, string clase, string metodo) : this(mensaje, clase, mensaje, null)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
    }
}
