using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Almohadon
    {
        private string tela;
        private float largo;
        private float ancho;
        private float grosor;
        private float volumen;
        private float area;
        private int cantHiloUsar;
        private static string telaEstatico;

        public string Tela { get => tela; }
        public float Largo { get => largo; }
        public float Ancho { get => ancho; }
        public float Grosor { get => grosor; }
        public static string TelaEstatico { get => telaEstatico; set => telaEstatico = value; }

        public Almohadon()
        {
        }

        public Almohadon(string tela, float largo, float ancho, float grosor)
        {
            this.tela = tela;
            this.largo = largo;
            this.ancho = ancho;
            this.grosor = grosor;
            this.cantHiloUsar = 30;
            this.volumen = largo * ancho * grosor;
            this.area = largo * ancho / 10000; //metros cuadrados
        }
    }
}
