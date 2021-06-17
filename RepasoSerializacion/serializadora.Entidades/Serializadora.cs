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
        public bool Guardar(List<Customer> persona)
        {
            bool retorno = false;

            try
            {
                Xml<List<Customer>> guardarPersona = new Xml<List<Customer>>();

                retorno = guardarPersona.Guardar(AppDomain.CurrentDomain.BaseDirectory + @"Custumers.xml", persona);
            }
            catch (MisExcepciones e)
            {
                this.mensaje = e.Message;
            }

            return retorno;

        }

        public List<Customer> Leer()
        {
            List<Customer> retorno = null;
            try
            {
                Xml<List<Customer>> leerPersona = new Xml<List<Customer>>();

                if (leerPersona.Leer(AppDomain.CurrentDomain.BaseDirectory + @"Custumers.xml", out List<Customer> auxPersona))
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
