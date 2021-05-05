using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo.Entidades
{
    public class Centralita
    {

        #region ATRIBUTOS

        protected string razonSocial;
        private List<Llamada> listaDeLlamada;

        #endregion

        #region PROPIEDADES

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamada;
            }
        }

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }


        #endregion

        #region CONSTRUCTORES


        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
            this.listaDeLlamada = new List<Llamada>();

        }

        public Centralita() : this("---")
        {

        }

        #endregion

        #region POLIMORFISMO

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Llamada item in this.listaDeLlamada)
            {
                sb.AppendLine("Razon social: " + this.razonSocial);
                sb.AppendLine("Ganancia Local: " + this.GananciaPorLocal.ToString());
                sb.AppendLine("Ganancia Provincial: " + this.GananciaPorProvincial.ToString());
                sb.AppendLine("Ganancias Totalales: " + this.GananciaTotal.ToString());
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        #endregion

        #region SOBRECARGAS

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {

            if (central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
            }

            return central;

        }

        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            bool retorno = false;

            if (Object.Equals(central, null) == false && Object.Equals(nuevaLlamada, null) == false)
            {

                foreach (Llamada auxiliar in central.Llamadas)
                {
                    if (auxiliar == nuevaLlamada)
                    {
                        retorno = true;
                        break;
                    }
                }

            }

            return retorno;
        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }


        #endregion

        #region METODOS

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if (Object.Equals(nuevaLlamada, null) == false)
            {
                this.listaDeLlamada.Add(nuevaLlamada);
            }
        }

        public void OrdenarLlamadas()
        {

            this.listaDeLlamada.Sort(Llamada.OrdenarPorDuracion);

        }


        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            float retorno = 0;

            foreach (Llamada item in this.Llamadas)
            {
                if (item is Local)
                {
                    gananciaLocal += item.CostoLLamada;
                }
                else
                {
                    gananciaProvincial += item.CostoLLamada;
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


        #endregion

    }
}
