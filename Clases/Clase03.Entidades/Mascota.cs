using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.Entidades
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private DateTime fechaNac;
        private Vacuna[] vacunas;

        public Mascota(string nombre, string especie, DateTime fechaNac)
        {
            this.vacunas = new Vacuna[2];
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNac = fechaNac;
        }

        public Mascota()
        {
            this.vacunas = new Vacuna[2];
        }

        private int BuscarLibre()
        {
            int retorno = -1;

            for (int i = 0; i < vacunas.Length; i++)
            {
                if (vacunas[i] is null)
                {
                    retorno = i;
                }
            }

            return retorno;
        }

        public void AddVacuna(string vacuna)
        {
            int index = this.BuscarLibre();

            if (index != -1)
            {
                this.vacunas[index] = new Vacuna(vacuna);
            }
            else
            {
                Array.Resize(ref this.vacunas, this.vacunas.Length +1);
                this.vacunas[this.BuscarLibre()] = new Vacuna(vacuna);
            }

        }

        public string MostrarMascota()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0} - Especie: {1} - Fecha de Nacimiento: {2}\n\n", this.nombre, this.especie, this.fechaNac.ToString("dd/MM/yyyy"));
            sb.AppendLine("Vacunas:");

            foreach (Vacuna item in vacunas)
            {
                sb.AppendLine(item.ObtenerNombreVacuna());
            }

            return sb.ToString();
        }

    }
}
