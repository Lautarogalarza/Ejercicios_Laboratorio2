using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuervo : AnimalVolador, IMensaje, IEncriptado
    {
        public Cuervo(string nombre) : base(nombre)
        {
        }

        public string EnviarMensaje()
        {
            return "Lleg el invierno";
        }

        string IEncriptado.EnviarMensaje()
        {
            return "Jon Snow es el verdadero rey";
        }
    }
}
