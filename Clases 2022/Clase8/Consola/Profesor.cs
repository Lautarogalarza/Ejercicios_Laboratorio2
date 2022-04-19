using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    sealed class Profesor : Persona
    {
        private string catedra;
        public Profesor(string nombre, string apellido, long dni,string catedra) 
        : base(nombre, apellido, dni)
        {
            this.catedra = catedra;
        }

        public string Catedra { get => catedra; set => catedra = value; }

        public string Corregir()
        {
            return "Estoy corrigiendo...";
        }
    }
}
