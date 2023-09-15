using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02
{
    public class Persona
    {
        private string nombre;
        private string fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, string fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public string Dni { get => dni; set => dni = value; }


        private int CalcularEdad()
        {
            int edad;
            DateTime date;
            date = Convert.ToDateTime(FechaDeNacimiento);

            DateTime nacimiento = new DateTime(date.Year, date.Month, date.Day); //Fecha de nacimiento
            edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            return edad;

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El nombre es: {Nombre}");
            sb.AppendLine($"Su fecha de nacimiento es: {FechaDeNacimiento}");
            sb.Append($"Su dni es: {Dni}");
            return sb.ToString();

        }


        public string EsMayorDeEdad()
        {
            int edad;

            edad = CalcularEdad();

            if (edad > 17)
            {
                return "Es Mayor de edad\n";
            }
            else
                return "Es menor de edad\n";


        }
    }
}
