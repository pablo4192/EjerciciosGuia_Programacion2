using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Interface_Ej02;
using System.Collections.Generic;

namespace Guia_Interfaces_Test_Ej02
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            GestionImpuestos gestion = new GestionImpuestos();
            List<Paquete> listaPaquetes = new List<Paquete>();

            PaqueteFragil pf1 = new PaqueteFragil("123", (decimal)5.5, "Burzaco", "Temperley", 5);
            PaqueteFragil pf2 = new PaqueteFragil("678", (decimal)3, "Pompeya", "Tapiales", 2.5);
            PaquetePesado pp1 = new PaquetePesado("456", (decimal)8.9, "Bariloche", "Longchamps", 25);
            PaquetePesado pp2 = new PaquetePesado("890", (decimal)10, "Lanus", "Villa Gessel", 55);

            listaPaquetes.Add(pf1);
            listaPaquetes.Add(pf2);
            listaPaquetes.Add(pp1);
            listaPaquetes.Add(pp2);

            gestion.RegistrarImpuestos(listaPaquetes);

            Assert.AreEqual((decimal)9.59, gestion.CalcularTotalImpuestosAduana());
            

            

        }

        [TestMethod]
        public void CalcularToTalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            GestionImpuestos gestion = new GestionImpuestos();
            List<Paquete> listaPaquetes = new List<Paquete>();

            PaqueteFragil pf1 = new PaqueteFragil("123", (decimal)5.5, "Burzaco", "Temperley", 5);
            PaqueteFragil pf2 = new PaqueteFragil("678", 3, "Pompeya", "Tapiales", 2.5);
            PaquetePesado pp1 = new PaquetePesado("456", (decimal)8.9, "Bariloche", "Longchamps", 25);
            PaquetePesado pp2 = new PaquetePesado("890", 10, "Lanus", "Villa Gessel", 55);

            listaPaquetes.Add(pf1);
            listaPaquetes.Add(pf2);
            listaPaquetes.Add(pp1);
            listaPaquetes.Add(pp2);

            gestion.RegistrarImpuestos(listaPaquetes);

            Assert.AreEqual((decimal)4.725, gestion.CalcularTotalImpuestosAfip());
        }


    }
}
