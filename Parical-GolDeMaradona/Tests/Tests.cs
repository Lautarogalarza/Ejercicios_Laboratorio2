using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _20201203;
using System.Windows.Forms;
using Entidades;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [ExpectedException(typeof(JugadaActivaException))]
        public void JugadaActivaExceptionTests()
        {
            GolDelSiglo gol = new GolDelSiglo();

            gol.IniciarJugada();
            gol.IniciarJugada();
        }

        [TestMethod]
        public void ExtensoraTests()
        {
            PictureBox pictureBox = new PictureBox();

            pictureBox.Name = "Aguante Dragon Ball Z";

            string letraFinal = pictureBox.Extensor();

            Assert.AreEqual("Z",letraFinal);

        }
    }
}
