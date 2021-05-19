using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializadora.Entidades
{
    public class Serializadora
    {
        public string mensaje;
        public bool Guardar(Persona persona)
        {
            bool retorno = false;

            try
            {
                Xml<Persona> guardarPersona = new Xml<Persona>();

                retorno = guardarPersona.Guardar(AppDomain.CurrentDomain.BaseDirectory + @"personas.xml", persona);
            }
            catch (MisExcepciones e)
            {
                this.mensaje = e.Message;
            }

            return retorno;

        }

        public Persona Leer()
        {
            Persona retorno = null;
            try
            {
                Xml<Persona> leerPersona = new Xml<Persona>();

                if (leerPersona.Leer(AppDomain.CurrentDomain.BaseDirectory + @"personas.xml", out Persona auxPersona))
                {
                    retorno = auxPersona;
                }

            }
            catch (MisExcepciones e)
            {

                this.mensaje = e.Message;
            }

            return retorno;

        }
    }
}
