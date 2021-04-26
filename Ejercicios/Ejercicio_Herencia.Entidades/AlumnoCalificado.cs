using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Herencia.Entidades
{
    public class AlumnoCalificado : Alumno
    {
        protected double nota;
        public AlumnoCalificado(string nombre, string apellido, int legajo, ETipoExamen examen, double nota) : base(nombre, apellido, legajo, examen)
        {
            this.nota = nota;
        }

        public AlumnoCalificado(Alumno alumno, double nota):this(alumno.GetNombre,alumno.GeApellido,alumno.GetLegajo,alumno.GetExamen,nota)
        {

        }

        public double GetNota
        {
            get
            {
                return this.nota;
            }
        }

        public string MostrarCalificado()
        {
            return base.MostrarAlumno() + " -- " + "Nota: " + this.GetNota;
        }

    }

}
