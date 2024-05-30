namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string dni;

        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido; 
            this.dni = dni;
        }

        public string Correr()
        {
            return "Corriendo por mi vida...........";
        }
    }
}