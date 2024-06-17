using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Unitarias
{
    [TestClass]
    public class Alumno_test
    {
        [TestMethod]
        public void Mostrar_CuandoAlumnoNoEsNulo_DeberiaRetornarLegajoYNombre()
        {
            //Arrange - Preparamos los valores que vamos a probar
            Alumno alumno = new Alumno("Juan", 123);
            string actual; //Retorno de la funcion
            string expected = "123 Juan";
            //Act - ejecutamos el metodo a testear
            actual = alumno.Mostrar();
            //Assert - Confirmamos que el valor recibido coincida con el esperado
            Assert.AreEqual(expected, actual);
        }
    }
}
