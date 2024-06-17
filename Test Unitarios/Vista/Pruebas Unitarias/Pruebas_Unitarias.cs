namespace Pruebas_Unitarias
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 2)]
        [DataRow(2, 4)]
        [DataRow(3, 8)]
        [DataRow(4, 16)]
        [DataRow(5, 32)]
        public void CalcularPotencia_CuandoExponenteEsMayorOIgualACero_DeberiaRetornarResultado(int exponente, int expected)
        {
            //Arrange - Preparamos los valores que vamos a probar
            int numero = 2;
            int actual; //Retorno de la funcion
            //Act - ejecutamos el metodo a testear
            actual = Aritmetica.CalcularPotencia(numero, exponente);
            //Assert - Confirmamos que el valor recibido coincida con el esperado
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcularPotencia_CuandoExponenteEsMenorACero_DeberiaLanzarArgumentException()
        {
            //Arrange - Preparamos los valores que vamos a probar
            int numero = 2;
            int exponente = -1;
            int actual; //Retorno de la funcion
            //Act - ejecutamos el metodo a testear
            actual = Aritmetica.CalcularPotencia(numero, exponente);
            //Assert - Confirmamos que el valor recibido coincida con el esperado
            //Assert.ThrowsException() - Solamente funciona con metodos que no retornan nada
        }
    }
}