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

        public int GetId 
        { 
            get 
            { 
                return this.id; 
            } 
        }

        public string GetNombre 
        { 
            get 
            { 
                return this.nombre; 
            } 
        }

        public string GetApellido 
        { 
            get 
            { 
                return this.apellido; 
            } 
        }

        public Persona(int id, string nombre, string apellido):this(nombre,apellido)
        {
            this.id = id;
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public override string ToString()
        {
            return "Nombre: " + this.nombre + "--" + "Apellido: " + this.apellido + "\n";
        }

    }
}
