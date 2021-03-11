using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio53.Entidades
{
    public class Cartuchera2
    {
        public List<Lapiz> lapices;
        public List<Boligrafo> boligrafos;

        public Cartuchera2()
        {
            this.lapices = new List<Lapiz>();
            this.boligrafos = new List<Boligrafo>();
        }

        public bool ProbarElementos()
        {
            bool retorno = true;

            foreach (Lapiz item in this.lapices)
            {
                if (((IAcciones)item).UnidadesDeEscritura -1 >= 0)
                {
                    ((IAcciones)item).UnidadesDeEscritura = -1;
                }
                else
                {
                    retorno = false;
                    break;
                }
            }

            foreach (Boligrafo item in this.boligrafos)
            {
                if (item.UnidadesDeEscritura - 1 > 0)
                {
                    item.UnidadesDeEscritura = -1;
                }
                else if (item.UnidadesDeEscritura - 1 == 0)
                {
                    item.UnidadesDeEscritura = -1;
                    item.Recargar(5);

                }
                else
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }
    }
}
