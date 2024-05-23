namespace Entidades
{
    public class Class1
    {
        public static bool Metodo1()
        {
            return Metodo2();        
        }

        public static bool Metodo2()
        {
            return Metodo3();
        }

        public static bool Metodo3()
        {
            try
            {
                int valor = 0;
                int[] numeros = { 1, 2, 3 };
                numeros[4] = 4;
                //int resultado = 5 / valor;
                //Console.WriteLine(resultado);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("lalalal");
                return false;
            }
            catch (IndexOutOfRangeException e)
            {
                throw new Exception($"Ocurrio un error {e.Message}",e);
            }
            catch(ArgumentException e)
            {
                throw new Exception($"Ocurrio un error {e.Message}", e);
            }
            catch(Exception e)
            {
                throw new Exception($"Ocurrio un error {e.Message}", e);
            }

            return true;
        }

        public static bool TryParse(string str, out int result)
        {
            try
            {
                result = int.Parse(str);
                return true;
            }
            catch (Exception)
            {
                result = 0;
                return false;
            }
        }
    }
}