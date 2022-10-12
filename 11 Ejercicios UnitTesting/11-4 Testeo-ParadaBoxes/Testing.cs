using Microsoft.VisualStudio.TestTools.UnitTesting;
using _11_4_Entidades;
using System;

namespace _11_4_Testeo_ParadaBoxes
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void Test_VerificaListadoNoNullAlInstanciar()
        {
            Competencia c = new Competencia(2,5,ETipoCompetencia.F1);
            Assert.IsNotNull(c.Competidores);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Test_VerificaExcepcionPorTipoDeVehiculoEnCompetencia()
        {
            //Arrange
            Competencia c = new Competencia(2, 5, ETipoCompetencia.MotoCross);
            AutoF1 f = new AutoF1(1, "auto");
            //Act
            _ =c + f;                    
        }

        [TestMethod]        
        public void Test_VerificaNoExcepcionPorTipoDeVehiculoEnCompetencia()
        {
            //Arrange
            Competencia c = new Competencia(2, 5, ETipoCompetencia.F1);
            AutoF1 f = new AutoF1(1,"auto");
            //Act
            _ = c + f;
        }

        [TestMethod]
        public void Test_VerificaListaCargada()
        {
            //Arrange
            Competencia c = new Competencia(2, 5, ETipoCompetencia.F1);
            AutoF1 f = new AutoF1(1, "auto",2);
            //Act
            Assert.IsFalse(c == f);
            Assert.IsTrue(c + f);
            Assert.IsTrue(c == f);
        }

        [TestMethod]
        public void Test_VerificaListaDescargada()
        {
            //Arrange
            Competencia c = new Competencia(2, 5, ETipoCompetencia.F1);
            AutoF1 f = new AutoF1(1, "auto", 2);
            //Assert
            Assert.IsFalse(c == f);
            Assert.IsTrue(c + f);
            Assert.IsTrue(c == f);
            Assert.IsTrue(c - f);
        }
    }
}
