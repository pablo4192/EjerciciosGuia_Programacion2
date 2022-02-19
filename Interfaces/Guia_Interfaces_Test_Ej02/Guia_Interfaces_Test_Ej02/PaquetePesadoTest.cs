using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Interface_Ej02;

namespace Guia_Interfaces_Test_Ej02
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            PaquetePesado pp = new PaquetePesado("456", (decimal)8.9, "Bariloche", "Longchamps", 25);

            Assert.AreEqual((decimal)8.9 + pp.Impuestos + ((IAfip)pp).Impuestos, pp.AplicarImpuestos());
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoDeEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            PaquetePesado pp = new PaquetePesado("456", (decimal)8.9, "Bariloche", "Longchamps", 25);

            Assert.AreEqual((decimal)(8.9 * 0.25), ((IAfip)pp).Impuestos);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoDeEnvio_CuandoEsImplementacionImplicita()
        {
            PaquetePesado pp = new PaquetePesado("456", (decimal)8.9, "Bariloche", "Longchamps", 25);

            Assert.AreEqual((decimal)(8.9 * 0.35), pp.Impuestos);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            PaquetePesado pp = new PaquetePesado("456", (decimal)8.9, "Bariloche", "Longchamps", 25);

            Assert.IsFalse(pp.TienePrioridad);
        }

    }
}
