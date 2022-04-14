using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Consola
{
    public class Auto
    {
        private string patente;
        private string marca;
        private int modelo;


        public Auto(string patente, string marca, int modelo)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
        }

        public string Patente { get => patente;}
        public int Modelo { get => modelo; }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Patente: {Patente}");
            sb.AppendLine($"Marca: {marca}");
            sb.AppendLine($"Modelo: {Modelo}");

            return sb.ToString();

        }

    }
}
