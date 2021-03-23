using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases04.Entidades
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private long dni;

        public Alumno(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.legajo = 0;
        }


        public void SetLegajo(Alumno alumno, int legajo)
        {
            alumno.legajo = legajo;
        }

        public long GetLegajo()
        {
            return this.legajo;
        }

        public Alumno(string nombre, string apellido, long dni ,int legajo) :this( nombre,apellido, dni)
        {
            this.legajo = legajo;
        }

        public static explicit operator long (Alumno alumno)
        {
            return alumno.dni;
        }


        public static implicit operator int(Alumno alumno)
        {
            return alumno.legajo;
        }

        public static bool operator + (Alumno alumno,int legajo)
        {
            bool retorno = false;
            alumno.SetLegajo(alumno,legajo);

            if (alumno.legajo!=0)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            bool retorno = false;
            if (alumno1.legajo == alumno2.legajo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            return !(alumno1 == alumno2);
        }


    }
}
