using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ILogs
    {
        bool Guardar();
        string Leer();
    }
}
