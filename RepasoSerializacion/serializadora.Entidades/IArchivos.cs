using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializadora.Entidades
{
    public interface IArchivos<T>
    {
        bool Guardar(string archivo, T datos);

        bool Leer(string archivo, out T datos);
    }
}
