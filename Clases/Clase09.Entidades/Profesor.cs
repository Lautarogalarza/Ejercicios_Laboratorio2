using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09.Entidades
{
    public class Profesor : Persona
    {
        public string catedra;

        public Profesor(string nombre, string apellido, long dni, string catedra) : base(nombre, apellido, dni)
        {
            this.catedra = catedra;
        }

        public string Corregir()
        {
            return "Estoy corrigiendo....";
        }

        public string MostrarProfesor()
        {
            return string.Format(base.MostrarPersona() + " Legajo: {0}", this.catedra);
        }

    }
}
