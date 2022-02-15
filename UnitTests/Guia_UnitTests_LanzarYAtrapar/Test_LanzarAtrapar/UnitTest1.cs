using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guia_UnitTests_LanzarYAtrapar;
using System;

namespace Test_LanzarAtrapar
{
    [TestClass]
    public class UnitTest1
    {

        [ExpectedException(typeof(UnaExcepcion))]
        [TestMethod]
        public void Test_Excepcion_MiClase()
        {
            MiClase miClase = new MiClase("hola");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Test_Excepcion_MiClaseString()
        {
            MiClase miClase = new MiClase();
        }

        [ExpectedException(typeof(MiExcepcion))]
        [TestMethod]
        public void Test_Excepcion_OtraClase()
        {
            OtraClase otraClase = new OtraClase();
        }

        [ExpectedException(typeof(DivideByZeroException))]
        [TestMethod]
        public void Test_Excepcion_MIClaseMetodo()
        {
            MiClase.Metodo();
        }


    }
}
