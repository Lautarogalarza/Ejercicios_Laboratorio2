using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
   // public delegate bool DelegadoCriterio<T>(T elemento);
    public static class ListaExtension
    {
        public static List<T> Filtrar<T>(this List<T> lista, Func<T,bool> criterioDeFiltrado)
        {
            List<T> listaFiltrada = new List<T>();

            foreach (var item in lista)
            {
                if (criterioDeFiltrado(item))
                {
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }
    }
}
