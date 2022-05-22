using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IPrueba<T>where T: Persona,new()
    {
        T MostrarPersona<U>(U nombre) where U : AnimalVolador;
    }
}
