using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuervo : AnimalVolador, IMensaje,IOculto
    {
        public Cuervo(string nombre):base(nombre)
        {
                
        }

        public string EnviarMensaje()
        {
            return "Llego el invierno";
        }

        string IOculto.EnviarMensaje()
        {
            return "Jon Snow el verdadero rey...";
        }
    }
}
