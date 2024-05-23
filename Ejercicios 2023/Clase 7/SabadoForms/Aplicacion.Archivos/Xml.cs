using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;


namespace Aplicacion.Archivos
{
    public class Xml<T>: Serializadora<T>
    {
        public override bool Guardar(string archivo, T datos)
        {
            bool retorno = false;

            try
            {
                XmlSerializer nuevoXml = new XmlSerializer(typeof(T));

                using (XmlTextWriter newTextWriter = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    nuevoXml.Serialize(newTextWriter, datos);
                    retorno = true;

                }

            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception($"Error: Directorio no encontrado {archivo}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer archivo externo {archivo}", ex);
            }

            return retorno;
        }

        public override bool Leer(string archivo, out T datos)
        {
            datos = default(T);
            bool retorno = false;

            try
            {

                XmlSerializer nuevoXml = new XmlSerializer(typeof(T));

                using (XmlTextReader newTextReader = new XmlTextReader(archivo))
                {
                    datos = (T)nuevoXml.Deserialize(newTextReader);
                    retorno = true;
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception($"Error: Directorio no encontrado {archivo}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer archivo externo {archivo}", ex);
            }

            return retorno;
        }
    }
}
