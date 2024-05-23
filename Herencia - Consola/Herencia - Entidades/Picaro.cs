using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia___Entidades
{
    public class Picaro : Heroe
    {
        private decimal nivelDeteccion;

        public Picaro(decimal vida, decimal mana, string nombre, int stamina, decimal nivelDeteccion)
            : base(vida, mana, stamina, nombre)
        {
            this.nivelDeteccion = nivelDeteccion;
        }

        public override string Ataque_01()
        {
            return $"Ataque Picaro: {Apuñalar()}";
        }

        protected bool Ocultarse()
        {
            if (nivelDeteccion > 50)
            {
                return true;
            }

            return false;
        }
        protected int Apuñalar()
        {
            if (Ocultarse())
            {
                return new Random().Next(4000, 20000);
            }

            return 0;
        }

        public override string Ataque_02()
        {
            return "Ataque picaro";
        }
    }
}
