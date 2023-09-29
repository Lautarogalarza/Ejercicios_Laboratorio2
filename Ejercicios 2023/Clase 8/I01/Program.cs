namespace I01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Camion camioncito = new Camion(8, 2, 8, Colores.Azul, 5000);
            Console.WriteLine($"Camion camioncito \nCantidad Ruedas: {camioncito.cantidadRuedas}\nCantidad Puertas: {camioncito.cantidadPuertas}\nColor: {camioncito.color}\nCantidad Marchas: {camioncito.cantidadMarchas}\nPeso Carga {camioncito.pesoCarga}");
            Console.WriteLine("--------------");
            Automovil autito = new Automovil(4, 5, 5, Colores.Blanco, 3);
            Console.WriteLine($"Automovil autito\nCantidad Ruedas: {autito.cantidadRuedas}\nCantidad Puertas: {autito.cantidadPuertas}\nColor: {autito.color}\nCantidad Marchas: {autito.cantidadMarchas}\nCantidad Pasajeros: {autito.cantidadPasajeros}");
            Console.WriteLine("-----------");
            Moto motito = new Moto(2, 0, Colores.Rojo, 1000);
            Console.WriteLine($"Moto motito\nCantidad Ruedas: {motito.cantidadRuedas}\nCantidad Puertas: {motito.cantidadPuertas}\nColor: {motito.color}\nCilindrada: {motito.cilindradas}");
        }
    }
}