using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48.Entidades
{
    public class Contabilidad<T, U> 
        where T : Documento 
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("Listado de: " + typeof(T).Name);
            foreach (T item in this.egresos)
            {
                cadena.AppendLine(item.ToString());
            }

            cadena.AppendLine("\nListado de: " + typeof(U).Name);
            foreach (U item in this.ingresos)
            {
                cadena.AppendLine(item.ToString());
            }

            return cadena.ToString();
        }

    }
}
