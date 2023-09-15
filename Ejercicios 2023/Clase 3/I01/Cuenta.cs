using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;

        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular { get => titular; }
        public float Cantidad { get => cantidad; }


        public string Mostrar()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"el titular es: {Titular}");
            sb.AppendLine($"monto disponible: {Cantidad}");

            return sb.ToString();

        }


        public bool Ingresar(float monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
                return true;
            }
            return false;

        }

        public bool Retirar(float monto)
        {
            if (monto > 0)
            {
                this.cantidad -= monto;
                return true;
            }
            return false;
        }
    }
}
