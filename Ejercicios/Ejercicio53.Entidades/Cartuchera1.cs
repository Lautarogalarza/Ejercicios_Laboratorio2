using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio53.Entidades
{
    public class Cartuchera1
    {
        public List<IAcciones> acciones;

        public Cartuchera1()
        {
            this.acciones = new List<IAcciones>();
        }

        public bool ProbarElementos()
        {
            bool retorno = true;

            foreach (IAcciones item in this.acciones)
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
