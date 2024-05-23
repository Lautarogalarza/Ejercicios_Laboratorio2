namespace Entidades
{
    public abstract class AnimalVolador
    {
        protected string nombre;

        public AnimalVolador(string nombre)
        {
            this.nombre = nombre;
        }

        public string Volar()
        {
            return "El solo de Free Bird...";
        }
    }
}