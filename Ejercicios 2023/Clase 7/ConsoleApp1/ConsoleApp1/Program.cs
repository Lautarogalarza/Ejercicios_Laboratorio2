namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 5;
            Stack<double> data = new Stack<double>();
            int i;

            for (i = max; i > 0; i--)
            {
                data.Push(i);
            }

            for (i = 0; i < max; i++)
            {
                Console.WriteLine(string.Format("{0}-",data.Pop()));
            }
        }
    }

    //public sealed abstract class Hola
    //{
    //    public void Enviar(string mensaje, string remitente, Usuario usuario, DateTime fecha)
    //    {

    //    }

    //    public void Enviar(string mensaje, string remitente, Usuario usuario)
    //    {

    //    }

    //    public void Enviar(Usuario usuario, string remitente,string mensaje , DateTime fecha)
    //    {

    //    }

    //    //internal void Enviar(string mensaje, string remitente, Usuario usuario, DateTime fecha)
    //    //{

    //    //}
    //}

    public class Usuario
    {
        private int numero;

    }


}