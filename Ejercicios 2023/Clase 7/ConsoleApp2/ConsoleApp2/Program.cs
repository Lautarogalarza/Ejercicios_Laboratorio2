using System.Text.Json;
using System;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pata pata = new Pata() { Color = "azul" };
            //Pata pata1 = new Pata();
            //Pata pata2 = new Pata();
            //Pata pata3 = new Pata();
            //string paths = $"{AppDomain.CurrentDomain.BaseDirectory + @"Custumers.xml"}";


            //List<Pata> patas = new List<Pata>();
            //patas.Add(pata);
            //patas.Add(pata1);
            //patas.Add(pata2);
            //patas.Add(pata3);

            //SillaPlasticaMonoPieza silla1 = new SillaPlasticaMonoPieza() 
            //{
            //    Color = "rojo",
            //    Patas = patas.ToArray(),
            //    Material = "Pino"
            //};
            //SillaPlasticaMonoPieza silla2 = new SillaPlasticaMonoPieza()
            //{
            //    Color = "rojo",
            //    Patas = patas.ToArray(),
            //};
            //SillaPlasticaMonoPieza silla3 = new SillaPlasticaMonoPieza()
            //{
            //    Color = "rojo",
            //    Patas = patas.ToArray(),
            //};
            //List<SillaPlasticaMonoPieza> sillas = new List<SillaPlasticaMonoPieza> ();

            //sillas.Add(silla1);
            //sillas.Add(silla2);
            //sillas.Add(silla3);


            using (StreamWriter sw = new(paths, true))
            {
                XmlSerializer xmlSerializer = new(typeof(List<SillaPlasticaMonoPieza>));
                xmlSerializer.Serialize(sw, sillas);
            }
        }
    }
}