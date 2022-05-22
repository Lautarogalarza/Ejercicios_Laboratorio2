using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio53.Entidades
{
    public class CartucheraMultiuso
    {
        public List<IAcciones> acciones;

        public CartucheraMultiuso()
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
