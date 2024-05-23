using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ICommand
    {
        public bool Exito { get; set; }
        public string Mensaje { get; set; }

        void Ejecutar();
    }
}
