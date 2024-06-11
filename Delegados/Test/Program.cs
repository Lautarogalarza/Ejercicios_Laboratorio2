namespace Test
{
    public delegate void DelegadoDestinatario();
    public delegate void DelegadoDestinatarioConTiempo(int tiempo);
    public class Program
    {
        static void Main(string[] args)
        {
            Receptor receptor1 = new Receptor("Lautaro");
            Receptor receptor2 = new Receptor("Gustavo");

            //DelegadoDestinatario delegadoUno = receptor1.RecibirNotificacion;
            //delegadoUno += receptor2.RecibirNotificacion;
            //delegadoUno += CambiarColorConsola;


            //delegadoUno();

            //Instanciando el delegado completo
            /*DelegadoDestinatario delegadoUno = new DelegadoDestinatario(receptor1.RecibirNotificacion);
            Emisor.destinatarios.Add(delegadoUno);*/

            //Pasandole solo la referencia al metodo
            // Emisor.destinatarios.Add(receptor1.RecibirNotificacion);


            //Instanciando el delegado de forma implicita
            /*DelegadoDestinatario delegadoDos = receptor2.RecibirNotificacion;
            Emisor.destinatarios.Add(delegadoDos);*/

            //Pasandole solo la referencia al metodo
             Emisor.destinatarios.Add(() => Console.BackgroundColor = ConsoleColor.Red);
            Emisor.destinatarios.Add(receptor2.RecibirNotificacion);

            //Emisor.destinatariosConTiempo.Add(Notificar);

            Emisor.ProducirNotificacion();
        }

        public static void Notificar(int tiempoDeEspera)
        {
            Console.WriteLine($"SE ENVIO UNA NOTIFICACION DESPUES DE {tiempoDeEspera}ms");
        }
    }

    public static class Emisor
    {
        public static Random random = new Random();


        public static List<DelegadoDestinatario> destinatarios = new List<DelegadoDestinatario>();
        public static List<DelegadoDestinatarioConTiempo> destinatariosConTiempo = new List<DelegadoDestinatarioConTiempo>();

        public static void ProducirNotificacion()
        {
            destinatarios.Sort((e1,e2) => string.Compare(e1.Method.Name, e2.Method.Name));
            var filtrado = destinatarios.Where(e => e.Method.Name.StartsWith('N')).ToList();
            // var filtrado2 = FiltrarLista(destinatarios);

            Console.WriteLine("Produciendo Notificacion");

            foreach (var item in destinatarios)
            {
                Thread.Sleep(2000);
                item();
            }

            foreach (var item in destinatariosConTiempo)
            {
                int tiempo = random.Next(2000, 5000);
                Thread.Sleep(tiempo);
                item(tiempo);
            }

        }

        /*public static List<DelegadoDestinatario> FiltrarLista(List<DelegadoDestinatario> destinatarios)
        {
            List<DelegadoDestinatario> destinatarios1 = new List<DelegadoDestinatario>();

            foreach (var item in destinatarios)
            {
                if (item.Method.Name.StartsWith('N'))
                {
                    destinatarios1.Add(item);
                }
            }

            return destinatarios1;
        }*/

        public static bool Filtrar(DelegadoDestinatario destinatario)
        {
            return destinatario.Method.Name.StartsWith('N');
        }

        public static int Comparar(DelegadoDestinatario elemento1, DelegadoDestinatario elemento2)
        {
            return string.Compare(elemento1.Method.Name, elemento2.Method.Name);
        }
    }

    public delegate void DelegadoDestinatario2();
    public class Receptor
    {
        string nombre;

        public Receptor(string nombre)
        {
            this.nombre = nombre;
        }

        public void RecibirNotificacion()
        {
            Console.WriteLine($"Yo {nombre} Recibi una notificacion a las {DateTime.Now}");
        }
    }
}