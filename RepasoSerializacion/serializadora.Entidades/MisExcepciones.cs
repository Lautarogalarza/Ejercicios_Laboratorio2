using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializadora.Entidades
{
    public class MisExcepciones:Exception
    {
        public MisExcepciones(Exception innerexception):base(innerexception.Message)
        {

        }
    }
}
