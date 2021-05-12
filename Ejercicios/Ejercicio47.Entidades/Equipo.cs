using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47.Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string GetNombre
        {
            get
            {
                return this.nombre;
            }
        }

        public DateTime GetFechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }

        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Equipo: {0}\n",this.nombre);
            sb.AppendFormat("Fundado el: {0}", this.GetFechaCreacion.ToString("dd/MM/yyyy"));

            return sb.ToString();
        }

    }
}
