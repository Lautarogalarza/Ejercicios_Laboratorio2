using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia___Entidades
{
    public sealed class Paladin : Tanque
    {
        private decimal poderDivino;
        public Paladin(decimal vida, decimal mana, string nombre, int stamina, decimal regeneracionVida, decimal poderDivino)
            : base(vida, mana, nombre, stamina, regeneracionVida)
        {
            this.poderDivino = poderDivino;
        }

        public override string Ataque_01()
        {
            return $"Ataque Paladin: {AtaqueDivino()}";
        }

        private int AtaqueDivino()
        {
            if (poderDivino > 0)
            {
                poderDivino -= 10;
                return new Random().Next(1000, 4000);
            }
            return 0;
        }
    }
}
