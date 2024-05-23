using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class ParametrosVaciosException:Exception
    {
        public ParametrosVaciosException() : base("Los parámetros están vacíos.")
        { }

        public ParametrosVaciosException(string mensaje) : base(mensaje)
        { }

        public ParametrosVaciosException(string mensaje, Exception ex) : base(mensaje, ex)
        { }
    }
}
