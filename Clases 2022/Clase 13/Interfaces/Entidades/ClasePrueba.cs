using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClasePrueba : IPrueba<Courier>
    {
        public Courier MostrarPersona<U>(U nombre) where U : AnimalVolador
        {
            return new Courier();
        }


        //public static string Probar(IMensaje mensaje)
        //{
        //    return mensaje.EnviarMensaje();
        //}
    }
}
