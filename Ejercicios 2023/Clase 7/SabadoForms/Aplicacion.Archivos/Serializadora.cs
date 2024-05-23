using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Archivos
{
    public abstract class Serializadora<T>
    {
        public abstract bool Guardar(string archivo, T datos);
        public abstract bool Leer(string archivo, out T datos);
    }
}
