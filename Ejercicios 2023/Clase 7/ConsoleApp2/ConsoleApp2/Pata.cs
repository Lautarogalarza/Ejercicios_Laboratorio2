using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Pata
    {
        public string Material { get; set; }

        public float Largo { get; set; }

        public float Ancho { get; set; }

        public string Color { get; set; }

        public float Grosor { get; set; }
        public float Volumen { get; set; }
        public float Area { get; set; }

        public Pata()
        {
        }

        public Pata(string material, float largo, float ancho, float grosor)
        {
            this.Material = material;
            this.Largo = largo;
            this.Ancho = ancho;
            this.Grosor = grosor;
            this.Volumen = Largo * Ancho * Grosor;
            this.Area = Largo * Ancho / 10000;
        }

        public Pata(string color, string material, float largo, float ancho, float grosor) : this(material, largo, ancho, grosor)
        {
            this.Color = color;
        }
    }
}
