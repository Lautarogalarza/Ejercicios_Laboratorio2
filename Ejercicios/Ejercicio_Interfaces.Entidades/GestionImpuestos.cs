using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Interfaces.Entidades
{
    public class GestionImpuestos
    {
        public List<IAduana> recuadoImpuestosAduana;
        public List<IAfip> recuadoImpuestosAfip;


        public GestionImpuestos()
        {
            this.recuadoImpuestosAduana = new List<IAduana>();
            this.recuadoImpuestosAfip = new List<IAfip>();
        }

        public double CalcularImpuestosTotalesAfip()
        {
            double retorno = 0;
            foreach (IAfip item in recuadoImpuestosAfip)
            {
                retorno += item.CalcularImpuesto();
            }
            return retorno;
        }
        public double CalcularImpuestosTotalesAduana()
        {
            double retorno = 0;
            foreach (IAduana item in recuadoImpuestosAduana)
            {
                retorno += item.CalcularImpuesto();
            }

            return retorno;
        }
    }

}

