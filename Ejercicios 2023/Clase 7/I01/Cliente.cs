using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01
{
    public class Cliente
    {
        int numero;
        string nombre;

        public Cliente(int numero)
        {
            this.numero = numero;

        }
        public Cliente(string nombre, int numero)
            : this(numero)
        {

            this.nombre = nombre;
        }

        public int Numero
        {
            get { return numero; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
