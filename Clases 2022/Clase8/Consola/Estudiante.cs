using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Estudiante : Persona
    {

        public string this[int i, string s]
        {
            get
            {
                return this[i, s];
            }
        }

        private int legajo;
        public List<string> materias;

        public Estudiante(Persona persona, int legajo)
        :base(persona.Nombre,persona.Apellido,persona.Dni)
        {
            this.legajo = legajo;
            materias = new List<string>();
        }

        public Estudiante(string nombre, string apellido, long dni, int legajo)
        : this(new Persona(nombre,apellido,dni),legajo)
        {
            
        }
        public int Legajo { get => legajo; set => legajo = value; }
        public string Estudiar()
        {
            return "Estoy estudiando....";
        }

    }
}
