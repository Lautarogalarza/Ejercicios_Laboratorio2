using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    public class SillaPlasticaMonoPieza
    {
        private string color;
        private string material;
        private float altura;
        private float ancho;
        private float grosor;
        private float volumen;
        private float area;
        private Pata[] patas;
        private Almohadon almohadon;
        private string plasticoEstatico;

        public Pata[] Patas { get => patas; set => patas = value; }
        public Almohadon Almohadon { get => almohadon; set => almohadon = value; }
        public string Material { get => material; set => material = value; }
        public float Grosor { get => grosor; }
        public string Color { get => color; set => color = value; }
        public string PlasticoEstatico { get => plasticoEstatico; set => plasticoEstatico = value; }
        public float Ancho { get => ancho; }
        public float Altura { get => altura; }

        public SillaPlasticaMonoPieza()
        {
        }

        public SillaPlasticaMonoPieza(float alto, float ancho, float grosor, string color)
        {
            this.color = color;
            this.altura = alto;
            this.ancho = ancho;
            this.grosor = grosor;
            //this.material = Materiales.Plastico.ToString();
            this.area = (altura * ancho) / 10000; //Area en metros cuadrados
            this.volumen = altura * ancho * grosor;
            // this.almohadon = almohadon;
            // this.patas = patas;
        }

    }
}
