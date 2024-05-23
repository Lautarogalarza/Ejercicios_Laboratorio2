using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia___Entidades
{
    public sealed class Nigromante : Mago
    {
        private int cantidadSubditos;
        public Nigromante(decimal vida, decimal mana, string nombre, int stamina, decimal regeneracionMana, int cantidadSubditos) : base(vida, mana, nombre, stamina, regeneracionMana)
        {
            this.cantidadSubditos = cantidadSubditos;
        }

        public int CantidadSubditos
        {
            get 
            { 
                return cantidadSubditos; 
            }
            set
            {
                cantidadSubditos = value;
            }

        }

        public override string Ataque_01()
        {
            return $"Comandar muertos: {ComandarMuerto()}";
        }

        public string FichaHeroe()
        {
            StringBuilder sb = new();
            sb.Append(base.FichaHeroe());
            sb.AppendLine($"Cantidad de subditos: {cantidadSubditos}");

            return sb.ToString();
        }

        private int ComandarMuerto()
        {
            if (cantidadSubditos > 0)
            {
                mana -= 5;
                return new Random().Next(50, 300);
            }

            return 0;
        }
    }
}
