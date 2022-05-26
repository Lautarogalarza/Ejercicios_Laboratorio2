using System;

namespace Entidades
{
    public class Persona
    {
        string nombre;
        int id;

        public Persona(string nombre):this(nombre,0)
        {

        }

        public Persona(string nombre, int id)
        {
            this.Nombre = nombre;
            this.Id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }



        public override string ToString()
        {
            return $"Nombre: {nombre}";
        }
    }
}
