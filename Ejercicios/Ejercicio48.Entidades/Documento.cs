using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48.Entidades
{
    public class Documento
    {
        private int numero;
        public Documento(int numero)
        {
            this.numero = numero;
        }

        public override string ToString()
        {
            return this.numero.ToString();
        }
    }
}
