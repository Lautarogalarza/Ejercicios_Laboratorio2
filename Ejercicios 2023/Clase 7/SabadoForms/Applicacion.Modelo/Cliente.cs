using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicacion.Modelo
{
    public class Cliente:Entidad
    {
        string nombre;
        string apellido;
        int edad;
       

        public Cliente(){}
        public Cliente(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }


        public static bool operator ==(List<Cliente> customers, Cliente customer)
        {
            foreach (Cliente item in customers)
            {
                if (item.nombre == customer.nombre && item.apellido == customer.apellido && item.edad == customer.edad)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(List<Cliente> customers, Cliente customer)
        {
            return !(customers == customer);
        }
    }
}
