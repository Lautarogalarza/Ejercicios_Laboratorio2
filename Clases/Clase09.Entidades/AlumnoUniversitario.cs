using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09.Entidades
{
    public class AlumnoUniversitario:Alumno
    {

        public List<string> correlativas;
        public List<int> notas;
        public AlumnoUniversitario(string nombre, string apellido, long dni, int legajo) : base(nombre, apellido, dni,legajo)
        {
            this.notas = new List<int>();
            this.correlativas = new List<string>();
        }

        public string RendirParcial()
        {
            return "Estoy rindiendo....";
        }

        public string RendirFinal()
        {
            return "Estoy pateando un final :c";
        }
    }
}
