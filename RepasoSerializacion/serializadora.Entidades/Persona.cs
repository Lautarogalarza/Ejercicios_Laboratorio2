using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serializadora.Entidades

{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public int Edad { get { return this.edad; } set { this.edad = value; } }
        public Persona()
        {

        }
        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n", this.Nombre);
            sb.AppendFormat("Apellido: {0}\n", this.Apellido);
            sb.AppendFormat("Edad: {0}\n", this.Edad);

            return sb.ToString();
        }

    }
}
