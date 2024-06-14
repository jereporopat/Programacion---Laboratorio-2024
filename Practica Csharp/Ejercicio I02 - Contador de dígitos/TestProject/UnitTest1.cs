using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contador_de_dígitos;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1,1)]
        [DataRow(-25,2)]
        [DataRow(48,2)]
        [DataRow(4000,4)]
        [DataRow(589,3)]
        [DataRow(-58,2)]
        [DataRow(-699,3)]
        public void ContarCantidadDeDigitos_CuandoElResultadoTieneNNumero_DeberiaRetornarN(long numero, int expected)
        {
            //arrange
            int actual;

            //act
            actual = numero.ContarCantidadDeDigitos();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}