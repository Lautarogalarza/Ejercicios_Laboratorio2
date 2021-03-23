using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.Entidades
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private double telefono;
        private Mascota[] mascotas;

        public Cliente(string domicilio, string nombre, string apellido, double telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mascotas = new Mascota[3];
        }

        public Cliente()
        {
            this.mascotas = new Mascota[3];
        }


        private int BuscarLibre()
        {
            int retorno = -1;

            for (int i = 0; i < mascotas.Length; i++)
            {
                if (mascotas[i] == null)
                {
                    retorno = i;
                    break;
                }
            }

            return retorno;
        }

        public void AddMascota(Mascota mascota)
        {
            int index = this.BuscarLibre();

            if (index!= -1)
            {
                this.mascotas[index] = mascota;
            }
            else
            {
                Array.Resize(ref this.mascotas, this.mascotas.Length + 1);
                this.mascotas[this.BuscarLibre()] = mascota;
            }

        }


        public string MostrarCliente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0} - Apellido: {1} - Domicilio: {2} - Telefono: {3}\n\n", this.nombre, this.apellido, this.domicilio, this.telefono);
            sb.AppendLine("Mascotas: \n");

            foreach (Mascota item in mascotas)
            {
                sb.AppendLine(item.MostrarMascota());
            }
            return sb.ToString();
        }



    }
}
