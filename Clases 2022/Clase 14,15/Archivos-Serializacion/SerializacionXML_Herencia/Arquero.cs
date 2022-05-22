using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXML_Herencia
{
    public enum ETipoArco
    {
        LargaDistancia,
        ArcoFuego
    }

    public class Arquero : Personaje
    {
        ETipoArco tipoArco;

        public Arquero()
        {
        }

        public Arquero(string nombre, int nivel, ETipoArco tipo) : base(nombre, nivel)
        {
            this.tipoArco = tipo;
        }

        public ETipoArco Tipo
        {
            get
            {
                return tipoArco;
            }
            set
            {
                this.tipoArco = value;
            }
        }


    }
}
