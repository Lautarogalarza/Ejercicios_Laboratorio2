using System;
using System.Xml.Serialization;

namespace Entidades
{
    //Implementará la interfaz IArchivos tantas veces como muestra el diagrama.Esto requerirá implementar la interfaz de forma implícita y de forma explícita.
    //Para Bombero: serializará y deserializará el objeto en formato XML. Almacenarlo en un archivo Bombero.xml en el escritorio.
    //Para string: guardará y leerá de la base de datos el mensaje recibido como parámetro.Al leer concatenar todos las entradas del log en un solo string.
    //El método AtenderSalida realizará lo siguiente:
    //Agregará una nueva salida a la lista del bombero.
    //Suspenderá el hilo entre 2 y 4 segundos.
    //Finalizará la salida.
    //Registrará la salida (horario de inicio, horario de fin y duración total) en la tabla log de la base de datos.
    //Avisará mediante el evento MarcarFin que se terminó la salida.Utilizar el parámetro bomberoIndex para informar al formulario cuál bombero fue.

    public delegate void FinDeSalida(int bomberoIndex);
    public class Bombero : IArchivo<Bombero>, IArchivo<string>
    {
        public event FinDeSalida MarcarFin;
        private static string rutaArchivo;
        private List<Salida> salidas;
        private string nombre;
        public static Random random;

        public Bombero(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Bombero()
        {
            salidas = new List<Salida>();
        }

        static Bombero()
        {
            rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Bombero.xml");
            random = new Random();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Salida> Salidas { get => salidas; set => salidas = value; }

        public void AtenderSalida(int bomberoIndex)
        {
            //1
            Salida salida = new Salida();
            salidas.Add(salida);

            //2
            Thread.Sleep(random.Next(2000,4000));

            //3
            salida.FinalizarSalida();

            //4
            string log = $"Salida finalizada. Inicio{salida.FechaInicio.ToLongTimeString()}. " + $"Fin: {salida.FechaFin.ToLongTimeString()}. Duracion: {salida.TiempoTotal} segundos.";
            ((IArchivo<string>)this).Guardar(log);

            //5
            MarcarFin.Invoke(bomberoIndex);
        }


        public void Guardar(Bombero info)
        {
            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
                xmlSerializer.Serialize(streamWriter, info);
            }
        }

        public Bombero Leer()
        {
            using (StreamReader streamReader = new StreamReader(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
                return xmlSerializer.Deserialize(streamReader) as Bombero;
            }
        }

        void IArchivo<string>.Guardar(string info)
        {
            LogDAO logDAO = new LogDAO();
            logDAO.InsertarLog(info);
        }

        string IArchivo<string>.Leer()
        {
            LogDAO logDAO = new LogDAO();
            return logDAO.LeerLog();
        }
    }
}