using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio57.Consola
{
   public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public Persona()
        {

        }


        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;

        }


        public static bool Guardar(Persona p)
        {
            XmlTextWriter writer = null;
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
            bool guardado = false;

            try
            {
                writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Persona.xml", Encoding.UTF8);
                ser.Serialize(writer, p);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al instanciar el Writer", ex);
            }
            finally
            {
                if (!(writer is null))
                {
                    writer.Close();
                    guardado = true;
                }
            }

            return guardado;
        }

        public static Persona Leer()
        {
            Persona p = null;
            XmlTextReader reader = null;
            XmlSerializer ser = new XmlSerializer(typeof(Persona));

            try
            {
                reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Persona.xml");
                p = (Persona)ser.Deserialize(reader);
            }
            catch(Exception ex)
            {
                throw new Exception("Error al instanciar el Reader", ex);
            }
            finally
            {
                if (!(reader is null))
                {
                    reader.Close();         
                }
            }

            return p;

        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", this.nombre, this.apellido);
            return sb.ToString();
        }

    }
}
