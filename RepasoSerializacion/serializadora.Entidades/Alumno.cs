using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serializadora.Entidades
{

    public class Alumno : Persona
    {
        private int legajo;
        private List<string> materias;

        public int Legajo { get { return this.legajo; } set { this.legajo = value; } }
        public List<string> Materias { get { return this.materias; } set { this.materias = value; } }


        public Alumno()
        {

        }

        public Alumno(int legajo, string nombre, string apellido, int edad) : base(nombre, apellido, edad)
        {
            this.legajo = legajo;
            this.materias = new List<string>();
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendFormat("Legajo: {0}\n", this.legajo);
            sb.AppendLine("Materias");

            foreach (string item in this.materias)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
