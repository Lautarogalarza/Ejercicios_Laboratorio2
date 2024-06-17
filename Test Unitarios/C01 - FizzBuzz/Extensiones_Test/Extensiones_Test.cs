namespace Extensiones_Test
{
    [TestClass]
    public class Extensiones_Test
    {
        [TestMethod]
        [DataRow(21)]
        [DataRow(33)]
        [DataRow(36)]
        [DataRow(42)]
        [DataRow(66)]
        [DataRow(-9)]
        public void FizzBuzz_CuandoNumeroEsDivisiblePorTres_DeberiaRetornarFizz(int numero)
        {
            //Arrange - Preparo los datos
            string expected = "Fizz";
            string actual;

            //Act - Llamo al metodo a probar
            actual = numero.FizzBuzz();

            //Assert - Verifico el resultado
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(25)]
        [DataRow(20)]
        [DataRow(55)]
        [DataRow(85)]
        [DataRow(115)]
        public void FizzBuzz_CuandoNumeroEsDivisiblePorCinco_DeberiaRetornarBuzz(int numero)
        {
            //Arrange - Preparo los datos
            string expected = "Buzz";
            string actual;

            //Act - Llamo al metodo a probar
            actual = numero.FizzBuzz();

            //Assert - Verifico el resultado
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(30)]
        [DataRow(45)]
        [DataRow(60)]
        [DataRow(90)]
        [DataRow(105)]
        public void FizzBuzz_CuandoNumeroEsDivisiblePorTresYPorCinco_DeberiaRetornarFizzBuzz(int numero)
        {
            //Arrange - Preparo los datos
            string expected = "FizzBuzz";
            string actual;

            //Act - Llamo al metodo a probar
            actual = numero.FizzBuzz();

            //Assert - Verifico el resultado
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(71)]
        [DataRow(88)]
        [DataRow(101)]
        [DataRow(34)]
        [DataRow(67)]
        public void FizzBuzz_CuandoNumeroNoEsDivisiblePorTresNiPorCinco_DeberiaRetornarNumero(int numero)
        {
            //Arrange - Preparo los datos
            string expected = numero.ToString();
            string actual;

            //Act - Llamo al metodo a probar
            actual = numero.FizzBuzz();

            //Assert - Verifico el resultado
            Assert.AreEqual(expected, actual);
        }
    }
}