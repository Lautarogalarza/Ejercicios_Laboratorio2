using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61.Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona(int id, string nombre, string apellido):this(nombre, apellido)
        {
            this.id = id;      
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Id { get { return this.id; } }
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Nombre: {this.Nombre} ");
            sb.AppendFormat($"Apellido: {this.apellido} ");

            return sb.ToString();
        }
    }
}
