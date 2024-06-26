using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Crear un nuevo tipo de excepción llamado BomberoOcupadoException con al menos dos sobrecargas de constructores.
    public class BomberoOcupadoException:Exception
    {
        public BomberoOcupadoException() : base()
        {
            
        }
        public BomberoOcupadoException(string message):base(message)
        {

        }

        public BomberoOcupadoException(string message, Exception innerExeption):base(message, innerExeption)
        {

        }
    }
}
