using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia___Entidades
{
    public class Tanque : Heroe
    {
        private decimal regeneracionVida;

        public Tanque(decimal vida, decimal mana, string nombre, int stamina, decimal regeneracionVida)
            : base(vida, mana, stamina, nombre)
        {
            this.regeneracionVida = regeneracionVida;
        }

        public override string Ataque_01()
        {
            return $"Escudo tanque: {GenerarEscudo()}";
        }

        public override string Ataque_02()
        {
            return "Ataque Tanque";
        }

        private decimal GenerarEscudo()
        {
            return new Random().Next(1000, 10000);
        }
    }
}
