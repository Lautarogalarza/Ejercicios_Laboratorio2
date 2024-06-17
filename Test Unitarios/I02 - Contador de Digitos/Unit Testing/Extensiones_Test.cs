using Entidades;

namespace Unit_Testing
{
    [TestClass]
    public class Extensiones_Test
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(7)]
        [DataRow(0)]
        [DataRow(-5)]
        [DataRow(3)]
        public void ContarCantidadDeDigitos_CuandoElNumeroTieneUnDigito_DeberiaRetornarUno(long numero)
        {
            //Arrange - preparacion
            int expected = 1;
            int actual;

            //Act - ejecutar el metodo
            actual = numero.ContarCantidadDeDigitos();

            //Assert - Verificar que el resultado obtenido coincida con el esperado
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(16)]
        [DataRow(72)]
        [DataRow(70)]
        [DataRow(-15)]
        [DataRow(33)]
        public void ContarCantidadDeDigitos_CuandoElNumeroTieneDosDigitos_DeberiaRetornarDos(long numero)
        {
            //Arrange - preparacion
            int expected = 2;
            int actual;

            //Act - ejecutar el metodo
            actual = numero.ContarCantidadDeDigitos();

            //Assert - Verificar que el resultado obtenido coincida con el esperado
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow(-578, 3)]
        [DataRow(-58, 2)]
        [DataRow(578, 3)]
        [DataRow(0, 1)]
        [DataRow(99, 2)]
        [DataRow(1084, 4)]
        public void ContarCantidadDeDigitos_CuandoElNumeroTieneNDigitos_DeberiaRetornarN(long numero, int expected)
        {
            //Arrange - preparacion
            int actual;

            //Act - ejecutar el metodo
            actual = numero.ContarCantidadDeDigitos();

            //Assert - Verificar que el resultado obtenido coincida con el esperado
            Assert.AreEqual(expected, actual);
        }
    }
}