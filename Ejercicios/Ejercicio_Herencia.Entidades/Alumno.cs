using System;
using System.Text;

namespace Ejercicio_Herencia.Entidades
{
    public class Alumno
    {
        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;

        public string GetNombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string GeApellido
        {
            get
            {
                return this.apellido;
            }
        }

        public int GetLegajo
        {
            get
            {
                return this.legajo;
            }
        }

        public ETipoExamen GetExamen
        {
            get
            {
                return this.examen;
            }
        }

        public Alumno(string nombre, string apellido, int legajo, ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }

        public string MostrarAlumno()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Legajo: {0} -- Nombre: {1} -- Apellido: {2} -- Examen: {3}", this.GetLegajo.ToString(), this.GetNombre, this.GeApellido, this.GetExamen);

            return sb.ToString();
        }

        public static bool operator ==(Alumno a, Alumno b)
        {
            if (object.Equals(a, null) == false && object.Equals(b, null) == false)
            {
                return (a.legajo == b.legajo);
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a == b);
        }

        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            return string.Compare(a.legajo.ToString(), b.legajo.ToString());
        }

        public static int OrdenarPorLegajoDesc(Alumno a, Alumno b)
        {
            return string.Compare(b.legajo.ToString(), a.legajo.ToString());
        }

        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {
            return string.Compare(a.apellido, b.apellido);
        }

        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return -1 * Alumno.OrdenarPorApellidoAsc(a, b);
        }

    }
}
