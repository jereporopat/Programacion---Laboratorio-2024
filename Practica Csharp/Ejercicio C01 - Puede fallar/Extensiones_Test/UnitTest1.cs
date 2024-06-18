using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Extensiones_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow (25)]
        [DataRow (50)]
        [DataRow (35)]
        [DataRow (40)]
        [DataRow (65)]
        [DataRow (5)]

        public void FizzBuzz_CuandoUnNumeroEsDivisiblePorTres_DeberiaRetornarFizz(int numero)
        {
            //arrange _ prerpar
            string expected = "Buzz";
            string actual;

            //act - Llamar al metodo a probar
            actual = numero.FizzBuzz();

            //Assert - verifica el resultado
            Assert.AreEqual (expected, actual);
        }
    }
}