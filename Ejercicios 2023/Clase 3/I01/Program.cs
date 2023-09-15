namespace I01
{
    public class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            int numerodeOrdenCuenta;
            float monto;
            bool salir = true;
            string respuesta;

            Cuenta cuentaJuan = new Cuenta("Juanse", 1500000);
            Cuenta cuentaLucas = new Cuenta("Lucas", 1800000);
            Cuenta cuentaNacho = new Cuenta("Ignacio", 165000);
            Cuenta cuentaOrnella = new Cuenta("Ornella", 1650000);


            do
            {

                Console.WriteLine($"N° 1 {cuentaJuan.Mostrar()}");

                Console.WriteLine($"N° 2 {cuentaLucas.Mostrar()}");

                Console.WriteLine($"N° 3 {cuentaNacho.Mostrar()}");

                Console.WriteLine($"N° 4 {cuentaOrnella.Mostrar()}");

                Console.WriteLine("Por favor ingrese a que cuenta desea ingresar");


                while (!int.TryParse(Console.ReadLine(), out numerodeOrdenCuenta) || (numerodeOrdenCuenta > 4 || numerodeOrdenCuenta < 1))
                {

                    Console.WriteLine("Por favor ingrese un valor correcto");

                }

                Console.WriteLine("Por favor ingrese que su opcion: 1 \"Depositar\", 2 \"Retirar\"");

                while (!int.TryParse(Console.ReadLine(), out opcion) || (opcion > 2 || opcion < 1))
                {
                    Console.WriteLine("Por favor ingrese la opcion correcta");
                }


                Console.WriteLine("Por favor ingrese el monto a operar: ");

                if (float.TryParse(Console.ReadLine(), out monto))
                {

                    switch (numerodeOrdenCuenta)
                    {
                        case 1:
                            switch (opcion)
                            {
                                case 1:
                                    cuentaJuan.Ingresar(monto);
                                    break;
                                default:
                                    cuentaJuan.Retirar(monto);
                                    break;
                            }
                            break;

                        case 2:
                            switch (opcion)
                            {
                                case 1:
                                    cuentaLucas.Ingresar(monto);
                                    break;
                                default:
                                    cuentaLucas.Retirar(monto);
                                    break;
                            }
                            break;

                        case 3:
                            switch (opcion)
                            {
                                case 1:
                                    cuentaNacho.Ingresar(monto);
                                    break;
                                default:
                                    cuentaNacho.Retirar(monto);
                                    break;
                            }
                            break;
                        case 4:
                            switch (opcion)
                            {
                                case 1:
                                    cuentaOrnella.Ingresar(monto);
                                    break;
                                default:
                                    cuentaOrnella.Retirar(monto);
                                    break;
                            }
                            break;


                        default:
                            break;
                    }

                }

                Console.WriteLine($"N° 1 {cuentaJuan.Mostrar()}");
                Console.WriteLine($"N° 2 {cuentaLucas.Mostrar()}");
                Console.WriteLine($"N° 3 {cuentaNacho.Mostrar()}");
                Console.WriteLine($"N° 4 {cuentaOrnella.Mostrar()}");

                Console.ReadKey();


                Console.WriteLine("Desea finalizar?, Si/No");

                respuesta = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(respuesta))
                {
                    if (respuesta == "Si")
                        salir = false;
                }

            } while (salir);
        }
    }
}