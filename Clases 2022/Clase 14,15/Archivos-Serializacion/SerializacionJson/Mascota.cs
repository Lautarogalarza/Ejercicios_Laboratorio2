using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionJson
{
    public class Mascota
    {
        string nombre;
        string raza;
        int edad;
        bool peloCorto;
        bool esPerro;

        public Mascota(string nombre, string raza, int edad, bool peloCorto, bool esPerro)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
            this.peloCorto = peloCorto;
            this.esPerro = esPerro;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Raza { get { return raza; } set { raza = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public bool PeloCorto { get { return peloCorto; } set { peloCorto = value; } }
        public bool EsPerro { get { return esPerro; } set { esPerro = value; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: " + this.nombre);
            sb.AppendLine($"Raza: " + this.raza);
            sb.AppendLine($"Edad: " + this.edad);
            sb.AppendLine($"PeloCorto: " + this.peloCorto);
            sb.AppendLine($"EsPerro: " + this.esPerro);

            return sb.ToString();

        }

    }
}
