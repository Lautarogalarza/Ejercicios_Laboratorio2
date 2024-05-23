using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09.Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected long dni;

        public string GetNombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string GetApellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }


        public long GetDni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }


        public Persona(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }


        public string MostrarPersona()
        {
            return String.Format("Nombre: {0}  Apellido: {1}  DNI: {2}", this.nombre, this.apellido, this.dni);
        }

    }
}
