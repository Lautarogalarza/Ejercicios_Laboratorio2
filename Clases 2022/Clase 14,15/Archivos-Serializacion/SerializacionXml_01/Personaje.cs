using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXml_01
{
    public class Personaje
    {

        private string nombre;
        private int nivel;

        public Personaje()
        {

        }

        public Personaje(string nombre,int nivel)
        {
            this.nombre = nombre;
            this.nivel = nivel;

        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre}  -  Nivel: {this.nivel}";
        }


    }
}