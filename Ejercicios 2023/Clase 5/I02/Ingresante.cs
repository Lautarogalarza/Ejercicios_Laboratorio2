using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private decimal edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante()
        {

        }
        public Ingresante(string[] cursos, string direccion, decimal edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Genero: {genero}");
            sb.AppendLine($"Edad: {edad}");
            sb.AppendLine($"Pais: {pais}");
            sb.AppendLine($"Direccion: {direccion}");
            sb.AppendLine($"Curso/s");

            foreach (string item in cursos)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    sb.AppendLine(item);
                }
            }

            return sb.ToString();
        }
    }
}
