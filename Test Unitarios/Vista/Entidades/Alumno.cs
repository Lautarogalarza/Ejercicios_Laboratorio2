using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private int legajo;
        private string nombre;

        public Alumno(string nombre, int legajo)
        {
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public string Mostrar()
        {
            return $"{legajo} {nombre}";
        }
    }
}
