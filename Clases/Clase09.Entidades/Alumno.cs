using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09.Entidades
{
    public class Alumno : Persona
    {
        public int legajo;
        public List<string> materias;
        public Alumno(string nombre, string apellido, long dni, int legajo):this(new Persona(nombre, apellido,dni),legajo)
        {
        }

        public Alumno(Persona persona, int legajo):base(persona.GetNombre, persona.GetApellido, persona.GetDni)
        {
            this.legajo = legajo;
            this.materias = new List<string>();
        }

        public string Estudiar()
        {
            return "Estoy estudiando....";
        }

        public string MostrarAlumno()
        {
            return string.Format(base.MostrarPersona() + " Legajo: {0}",this.legajo);
        }
    }
}
