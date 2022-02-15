using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guia_UnitTests_Ej01;

namespace Test_Guia_Ej01
{
    [TestClass]
    public class UnitTest1
    {
        #region DataRow del Punto 1 al 4
        //[DataRow("", 0)]
        //[DataRow("2", 2)]
        //[DataRow("1,2", 3)]
        //[DataRow("125, ", 125)]
        //[DataRow("  ,100", 100)]
        //[DataRow("  , 3", 3)]
        //[DataRow("Arre, kj8", 8)]
        //[DataRow("+-.,5ñl 5", 55)]
        //[DataRow(null, 0)]
        //[DataRow("1,2,3,4,5", 15)]
        //[DataRow("  +.-, 5,,,,  5, *yuta", 10)]
        //[DataRow("2\n2, 2", 6)]
        //[DataRow("1,\n, 2", 3)]
        //[DataRow("//:\n 2: 2", 4)]
        //[DataRow("//+ 2+2+2,4\n2", 12)]
        #endregion


        [ExpectedException(typeof(NegativoNoPermitidoException))]
        [TestMethod]
        public void TestMethod1(/*string numero, int retornoEsperado*/)
        {
            //int retorno;

            //Act
            //retorno = 
            
            Calculadora.Add("2, -4, 2");

            //Assert
            //Assert.IsTrue(retorno == retornoEsperado);
        }
    }
}
