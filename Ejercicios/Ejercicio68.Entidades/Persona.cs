using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio68.Entidades
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        public event DelegadoString EventoString;
        private string apellido;
        private string nombre;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (value != this.nombre)
                {
                    this.nombre = value;
                    this.EventoString.Invoke(this.Mostrar());
                }
            }
        }
        public string Apellido
        {
            get
            {
                
                return this.apellido;
            }
            set
            {
                if (value != this.apellido)
                {

                    this.apellido = value;
                    this.EventoString.Invoke(this.Mostrar());
                }
            }
        }

        public Persona()
        {
            this.apellido = string.Empty;
            this.nombre = string.Empty;

        }

        public string Mostrar()
        {
            return string.Format($"Nombre: {this.Nombre} -- Apellido: {this.Apellido}");
        }
    }
}
