using _13_2_Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_Testing
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduena()
        {
            PaquetePesado paquetePrueba = new PaquetePesado("123", (decimal)5575, "B", "A", 5);
            decimal valorTotalEsperado = (decimal)(5575 + 5575 * 0.25+ 5575 * 0.35);
            //Act
            decimal valorTotalObtenido = paquetePrueba.AplicarImpuestos();
            //Assert
            Assert.AreEqual(valorTotalEsperado, valorTotalObtenido);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            PaquetePesado paquetePrueba = new PaquetePesado("123", (decimal)5575.45, "B", "A", 5);
            decimal impuestoEsperado = (decimal)5575.45 * (decimal)0.25;
            //Act
            decimal impuestoObtenido = ((IAfip)paquetePrueba).Impuestos;
            //Assert
            Assert.AreEqual(impuestoEsperado, impuestoObtenido);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //Arrange
            PaquetePesado paquetePrueba = new PaquetePesado("123", (decimal)5575.45, "B", "A", 5);
            decimal impuestoEsperado = (decimal)5575.45*(decimal)0.35;
            //Act
            decimal impuestoObtenido = paquetePrueba.Impuestos;
            //Assert
            Assert.AreEqual(impuestoEsperado, impuestoObtenido);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            PaquetePesado paquetePrueba = new PaquetePesado("123", (decimal)5575.45, "B", "A", 5);
            Assert.IsFalse(paquetePrueba.TienePrioridad);
        }
    }
}
