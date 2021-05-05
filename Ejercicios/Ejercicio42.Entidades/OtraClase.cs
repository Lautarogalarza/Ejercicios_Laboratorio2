using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio42.Entidades
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {
            try
            {
                MiClase miClase = new MiClase("Este es un mensaje");
            }
            catch (UnaExcepcion e)
            {

                throw new MiException("Fallo en otra clase",e);
            }
        }
    }
}
