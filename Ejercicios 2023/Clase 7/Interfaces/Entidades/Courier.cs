﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Courier:Persona,IMensaje
    {
        public Courier()
        {
                
        }
        public Courier(string nombre, string apellido, string dni):base(nombre,apellido,dni)
        {
                
        }
        public string EnviarMensaje()
        {
            return "La ficha esta en el lucky 38.....";
        }
    }
}
