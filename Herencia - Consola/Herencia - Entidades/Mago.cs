using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia___Entidades
{
    public class Mago : Heroe
    {
        private decimal regeneracionMana;
        public Mago(decimal vida, decimal mana, string nombre, int stamina, decimal regeneracionMana)
            : base(vida, mana, stamina, nombre)
        {
            this.regeneracionMana = regeneracionMana;
        }

        public string FichaHeroe()
        {
            StringBuilder sb = new();
            sb.Append(base.ToString());
            sb.AppendLine($"Regeneracion de mana: {regeneracionMana}");

            return sb.ToString();
        }

        public decimal LanzarHechizo()
        {
            if (mana > 2)
            {
                mana -= 2;
                return new Random().Next(100, 1000);
            }
            return 0;
        }

        public override string Ataque_01()
        {
            return $"Ataque Mago: {LanzarHechizo()}";
        }

        public override string Ataque_02()
        {
            return "Ataque 2 mago";
        }
    }
}
