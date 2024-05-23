using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // PersonaDAO.Guardar("Lautaro");
            //  PersonaDAO.Guardar("Mathias");
            ///PersonaDAO.Guardar("Lucas");
            ///

            //PersonaDAO.Modificar("Lauti", 3);

            var personas = PersonaDAO.Leer();

            foreach (var item in personas)
            {
                Console.WriteLine(item);
            }



           // Console.WriteLine(PersonaDAO.Leer(2));
            //PersonaDAO.Eliminar(2);
        }
    }
}