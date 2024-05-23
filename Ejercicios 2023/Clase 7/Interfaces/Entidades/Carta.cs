using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carta:Papel,IMensaje
    {
        private string sello;

        public Carta(string sello, string tipo, int cantHojas) : base(tipo, cantHojas)
        {
            this.sello = sello;
        }

        public string EnviarMensaje()
        {
            return "Nos rendimos :c.....";
        }
    }
}
