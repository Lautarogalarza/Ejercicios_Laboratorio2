using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion_03
{
    public class Arquero:Personaje
    {
        bool tieneArmadura;

        public Arquero()
        {

        }

        public Arquero(string nombre, int nivel, bool tieneArmadura):base(nombre,nivel)
        {
            this.tieneArmadura = tieneArmadura;
        }

        public bool TieneArmadura { get => tieneArmadura; set => tieneArmadura = value; }
    }
}
