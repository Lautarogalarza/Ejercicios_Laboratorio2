using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private float precio;
        private int numero;

        public float Precio { get { return this.precio; } set { this.precio = value; } }
        public int Numero { get { return this.numero; } set { this.numero = value; } }

        public Factura()
        {

        }
        public Factura(float precio, int numero)
        {
            this.numero = numero;
            this.precio = precio;
        }

    }
}
