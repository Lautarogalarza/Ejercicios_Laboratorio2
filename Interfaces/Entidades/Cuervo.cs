using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuervo : AnimalVolador, IMensaje, IEncriptado
    {
        public Cuervo(string nombre) : base(nombre) { }

        public string EnviarMensaje()
        {
            return "Le declaramos la guerra al gobierno mundial";
        }

        public int Prueba()
        {
            throw new NotImplementedException();
        }

        string IEncriptado.EnviarMensaje()
        {
            return "La fruta se llama Ito Ito no mi: Model Nika";
        }
    }
}
