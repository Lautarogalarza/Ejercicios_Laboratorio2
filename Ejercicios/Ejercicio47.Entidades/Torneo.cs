using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47.Entidades
{
    public class Torneo<T> where T : Equipo
    {

        private List<T> equipos = new List<T>();
        private string nombre;

        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                return this.CalcularPartido(this.equipos[random.Next(0, this.equipos.Count)], this.equipos[random.Next(0, this.equipos.Count)]);
            }
        }

        public Torneo(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            bool retorno = false;

            foreach (T item in torneo.equipos)
            {
                if (item.GetFechaCreacion == equipo.GetFechaCreacion && item.GetNombre == equipo.GetNombre)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

       public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator + (Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }

            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("TORNEO: {0}\n\n", this.nombre);

            foreach (T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random random = new Random();

            int resultado1 = random.Next(0, 10);
            int resultado2 = random.Next(0, 10);

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} {1} - {2} {3} ", equipo1.GetNombre, resultado1, resultado2, equipo2.GetNombre);

            return sb.ToString();
        }

    }
}
