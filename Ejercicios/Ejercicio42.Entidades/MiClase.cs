using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio42.Entidades
{
   public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.MetodoStatic();
            }
            catch (DivideByZeroException e)
            {

                throw e;
            }
        }

        public MiClase(string unMensaje)
        {
            try
            {
                MiClase clase = new MiClase();
            }
            catch (DivideByZeroException e)
            {

                throw new UnaExcepcion("Fallo en Mi clase", e);
            }
        }

        public static void MetodoStatic()
        {
            throw new DivideByZeroException();
        }
    }
}
