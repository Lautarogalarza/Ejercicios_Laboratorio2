using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10_Entidades
{
    public class Class1
    {
        public string cadena;

        public char this[int index]
        {
            get
            {
                return this.cadena[index];
            }
            set
            {
                if (index >= 0 && index < this.cadena.Length)
                {
                    this.cadena[index] = value;
                }
                
            }
        }

    }
}
