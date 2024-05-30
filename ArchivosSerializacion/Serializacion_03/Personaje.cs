using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serializacion_03
{
    //Cuando serializamos clases en una relacion de herencia en XML vamos a tener que especificar en la clase padre las clases derivadas que tambien se van a tener que serializar
    [XmlInclude(typeof(Arquero))]
    [XmlInclude(typeof(Espadachin))]
    public class Personaje
    {
        private string nombre;
        private int nivel;

        public Personaje()
        {

        }

        public Personaje(string nombre, int nivel)
        {
            this.nombre = nombre;
            this.nivel = nivel;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Nivel { get => nivel; set => nivel = value; }


        public override string ToString()
        {
            return $"Nombre: {this.nombre} - Nivel {this.Nivel}";
        }
    }
}
