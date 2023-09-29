using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03
{
    public class Centralita
    {
        private List<Llamada> listaLlamada;
        private string razonSocial;

        public Centralita(string razonSocial)
        {
            this.razonSocial = razonSocial;
            listaLlamada = new List<Llamada>();
        }

        public Centralita():this("Lauti Center")
        {
                
        }

        public float GananciaPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciaPorTotal { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> ListaLlamada { get => listaLlamada;}

        public void OrdenarLlamadas()
        {
            listaLlamada.Sort(Llamada.OrdenarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Razon Social: {razonSocial}");
            foreach (var item in listaLlamada)
            {
                if (item is Local l)
                {
                    sb.AppendLine(l.Mostrar());
                }
                else if(item is Provincial p) 
                {
                    sb.AppendLine(p.Mostrar());
                }
            }

            ////stringBuilder.AppendLine($"Ganancia Local:{GananciaPorLocal}");
            ////stringBuilder.AppendLine($"Ganancia Provincial:{GananciaPorProvincial}");
            ////stringBuilder.AppendLine($"Ganancia Total:{GananciaPorTotal}");


            return sb.ToString();
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            float retorno = 0;

            foreach (var item in listaLlamada)
            {
                if (item is Local l)
                {
                    gananciaLocal += l.Costo;
                }
                else if(item is Provincial p)
                {
                    gananciaProvincial += p.CostoLlamada;
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    retorno = gananciaLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    retorno = gananciaProvincial;
                    break;
                case Llamada.TipoLlamada.Todas:
                    retorno = gananciaLocal + gananciaProvincial;
                    break;
                default:
                    break;
            }

            return retorno;
        }

    }
}
