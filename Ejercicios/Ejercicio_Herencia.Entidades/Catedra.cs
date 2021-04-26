using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Herencia.Entidades
{
    public class Catedra
    {
        private List<Alumno> alumnos;

        public Catedra()
        {
            this.alumnos = new List<Alumno>();
        }

        public List<Alumno> GetAlumnos
        {
            get
            {
                return this.alumnos;
            }
        }

        public Alumno this[int index]
        {
            get
            {
                return this.alumnos[index];
            }
            set
            {
                if (index >= 0 && index < this.alumnos.Count)
                {
                    this.alumnos[index] = value;
                }
                else
                {
                    this.alumnos.Add(value);
                }
            }
        }


        public static bool operator ==(Catedra c, Alumno a)
        {
            bool retorno = false;
            if (Object.Equals(c, null) == false && Object.Equals(a, null) == false)
            {
                if (c.GetAlumnos.Contains(a))
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static int operator |(Catedra c, Alumno a)
        {
            int retorno = -1;

            if (Object.Equals(c, null) == false && Object.Equals(a, null) == false)
            {
                if (c == a)
                {
                    retorno = c.alumnos.IndexOf(a);
                }
            }
            return retorno;
        }

        public static bool operator !=(Catedra c, Alumno b)
        {
            return !(c == b);
        }

        public static bool operator +(Catedra c, Alumno a)
        {
            bool retorno = false;
            if (Object.Equals(c, null) == false && Object.Equals(a, null) == false)
            {
                if (c != a)
                {
                    c.alumnos.Add(a);
                    retorno = true;
                }
            }
            return retorno;
        }

    }
}
