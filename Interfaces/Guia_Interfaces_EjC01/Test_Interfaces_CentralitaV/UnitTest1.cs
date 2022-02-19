using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guia_Interfaces_EjC01;

namespace Test_Interfaces_CentralitaV
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Centralita_ListaLlamadas()
        {
            Centralita centralita = new Centralita();

            Assert.IsNotNull(centralita.Llamadas);
        }

        [ExpectedException(typeof(CentralitaException))]
        [TestMethod]
        public void Test_CentralitaException_Local()
        {
            Centralita centralita = new Centralita();
            Llamada llamadaLocal1 = new Local("15666666", 2, "15444444", 5);
            Llamada llamadaLocal2 = new Local("15666666", 8, "15444444", 2);

            centralita = centralita + llamadaLocal1;
            centralita = centralita + llamadaLocal2;

        }

        [ExpectedException(typeof(CentralitaException))]
        [TestMethod]
        public void Test_CentralitaException_Provincial()
        {
            Centralita centralita = new Centralita();
            Llamada llamadaProvincial1 = new Provincial("11111111", Provincial.EFranja.Franja_3, 20, "22222222");
            Llamada llamadaProvincial2 = new Provincial("11111111", Provincial.EFranja.Franja_1, 5, "22222222");

            centralita = centralita + llamadaProvincial1;
            centralita = centralita + llamadaProvincial2;

        }

        [TestMethod]
        public void Test_IgualdadEntreLlamadas()
        {

            Llamada llamadaProvincial1 = new Provincial("11111111", Provincial.EFranja.Franja_3, 20, "22222222");
            Llamada llamadaProvincial2 = new Provincial("11111111", Provincial.EFranja.Franja_1, 5, "22222222");
            Llamada llamadaLocal1 = new Local("11111111", 2, "22222222", 5);
            Llamada llamadaLocal2 = new Local("11111111", 8, "22222222", 2);

            Assert.IsTrue(llamadaProvincial1 == llamadaProvincial2);
            Assert.IsFalse(llamadaProvincial1 == llamadaLocal1);
            Assert.IsFalse(llamadaProvincial1 == llamadaLocal2);

            Assert.IsTrue(llamadaProvincial2 == llamadaProvincial1);
            Assert.IsFalse(llamadaProvincial2 == llamadaLocal1);
            Assert.IsFalse(llamadaProvincial2 == llamadaLocal2);

            Assert.IsTrue(llamadaLocal1 == llamadaLocal2);
            Assert.IsFalse(llamadaLocal1 == llamadaProvincial1);
            Assert.IsFalse(llamadaLocal1 == llamadaProvincial2);

            Assert.IsTrue(llamadaLocal2 == llamadaLocal1);
            Assert.IsFalse(llamadaLocal2 == llamadaProvincial1);
            Assert.IsFalse(llamadaLocal2 == llamadaProvincial2);


        }
    }
}

