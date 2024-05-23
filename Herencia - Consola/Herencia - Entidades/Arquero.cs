using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia___Entidades
{
    public sealed class Arquero : Picaro
    {
        private int cantidadFlechas;

        public Arquero(decimal vida, decimal mana, string nombre, int stamina, decimal nivelDeteccion, int cantidadFlechas) : base(vida, mana, nombre, stamina, nivelDeteccion)
        {
            this.cantidadFlechas = cantidadFlechas;
        }

        public override string Ataque_01()
        {
            return $"Disparo arquero: {Disparar()}";
        }

        private int Disparar()
        {
            if (cantidadFlechas > 0 && Ocultarse())
            {
                cantidadFlechas--;
                return Apuñalar();
            }
            return 0;
        }
    }
}
