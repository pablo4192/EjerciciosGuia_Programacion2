using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Interface_Ej02;

namespace Guia_Interfaces_Test_Ej02
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            PaqueteFragil pf = new PaqueteFragil("123", (decimal)5.5, "Burzaco", "Temperley", 5);

            Assert.AreEqual((decimal)5.5 + pf.Impuestos, pf.AplicarImpuestos());
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            PaqueteFragil pf = new PaqueteFragil("123", (decimal)5.5, "Burzaco", "Temperley", 5);

            Assert.AreEqual((decimal)(5.5 * 0.35), pf.Impuestos);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            PaqueteFragil pf = new PaqueteFragil("123", (decimal)5.5, "Burzaco", "Temperley", 5);

            Assert.IsTrue(pf.TienePrioridad);
        
        }
    }
}
