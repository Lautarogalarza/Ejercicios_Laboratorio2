using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private long dni;

        public Persona()
        {
            this.nombre = string.Empty;
            this.fechaNacimiento = new DateTime(1990, 1, 1);
            this.dni = -1;
        }

        public Persona(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Persona(string nombre, DateTime fechaNac) : this(nombre)
        {
            this.fechaNacimiento = fechaNac;
        }

        public Persona(string nombre, DateTime fechaNac, long dni) : this(nombre, fechaNac)
        {
            this.dni = dni;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Fecha nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Dni: {dni}");

            return sb.ToString();
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            if (p1 is not null && p2 is not null)
            {
                return p1.nombre == p2.nombre;
            }

            return false;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        public static implicit operator long(Persona p1)
        {
            return p1.dni;
        }

        public static explicit operator string(Persona p1)
        {
            return p1.Mostrar();
        }


    }
}
