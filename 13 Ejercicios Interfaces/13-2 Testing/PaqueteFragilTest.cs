using Microsoft.VisualStudio.TestTools.UnitTesting;
using _13_2_Entidades;

namespace _13_2_Testing
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //Arrange
            PaqueteFragil paquetePrueba = new PaqueteFragil("123", 100, "B", "A", 5);
            decimal valorTotalEsperado = 135;
            //Act
            decimal valorTotalObtenido = paquetePrueba.AplicarImpuestos();
            //Assert
            Assert.AreEqual(valorTotalEsperado, valorTotalObtenido);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestosDel35PorcientoSobreCostoEnvio()
        {
            //Arrange
            PaqueteFragil paquetePrueba = new PaqueteFragil("123",100,"B","A",5);
            decimal impuestoEsperado = 35;
            //Act
            decimal impuestoObtenido = paquetePrueba.Impuestos;
            //Assert
            Assert.AreEqual(impuestoEsperado, impuestoObtenido);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange          
            PaqueteFragil paquetePrueba = new PaqueteFragil("123", 100, "B", "A", 5);
            //Act y Assert
            Assert.IsTrue(paquetePrueba.TienePrioridad);
            
        }
    }
}
