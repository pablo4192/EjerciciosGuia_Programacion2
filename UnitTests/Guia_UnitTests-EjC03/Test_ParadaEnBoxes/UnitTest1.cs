using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guia_UnitTests_EjC03;

namespace Test_ParadaEnBoxes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_InstanciaListaCompetidores()
        {
            Competencia competencia = new Competencia(3, 5, Competencia.TipoCompetencia.F1);

            Assert.IsNotNull(competencia.Competidores);
        }

        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        [TestMethod]
        public void Test_CompetenciaNoDisponibleException()
        {
            Competencia competencia = new Competencia(3, 5, Competencia.TipoCompetencia.MotoCross);
            AutoF1 auto = new AutoF1(1, "Fiat", 300);

            _ = competencia + auto;

        }

        [TestMethod]
        public void Test_CompetenciaMotoCross_AddMotoCross()
        {
            Competencia competencia = new Competencia(3, 5, Competencia.TipoCompetencia.MotoCross);
            
            Assert.IsTrue(competencia + new MotoCross(3, "Gilera"));
            Assert.IsNotNull(competencia.Competidores);

        }

        [TestMethod]
        public void Test_AgregarVehiculoACompetencia()
        {
            Competencia competencia = new Competencia(3, 5, Competencia.TipoCompetencia.MotoCross);
            VehiculoDeCarrera moto = new MotoCross(3, "Gilera", 125);

            Assert.IsTrue(competencia + moto);
            Assert.IsTrue(competencia == moto);
        }

        [TestMethod]
        public void Test_QuitarVehiculoACompetencia()
        {
            Competencia competencia = new Competencia(3, 5, Competencia.TipoCompetencia.F1);
            VehiculoDeCarrera auto = new AutoF1(5, "Mercedes", 450);

            Assert.IsTrue(competencia + auto);
            Assert.IsTrue(competencia - auto);
            Assert.IsTrue(competencia != auto);
        }





    }
}
