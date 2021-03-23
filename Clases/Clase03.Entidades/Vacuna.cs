using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.Entidades
{
    public class Vacuna
    {
       private string nombre;

        public Vacuna(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenerNombreVacuna()
        {
           return this.nombre;
        }
    }
}
