using System.Text;

namespace C03
{
    public class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion { get => duracion; }
        public string NroDestino { get => nroDestino; }
        public string NroOrigen { get => nroOrigen; }


        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada1.duracion - llamada2.duracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Duracion: {duracion}");
            sb.AppendLine($"Destino: {nroDestino}");
            sb.AppendLine($"Origen: {nroOrigen}");

            return sb.ToString();
        }
    }
}