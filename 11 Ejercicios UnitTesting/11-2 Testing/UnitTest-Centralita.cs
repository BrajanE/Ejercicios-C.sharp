using Microsoft.VisualStudio.TestTools.UnitTesting;
using _11_2_Entidades;

namespace _11_2_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Verificar_InstaciadoDeListaLLamada()
        {
            //Arrange
            Centralita central = new Centralita();
            //Assert
            Assert.IsNotNull(central.LLamadas);           
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Test_Verifica_CentralitaExcepcionPorLLamadaLocal()
        {
            //Arrange
            Local l1 = new Local("123",65,"321",234);
            Local l2 = new Local("123", 25, "321", 100);
            //Act
            Centralita central = new Centralita();
            _=central + l1;
            _=central + l2;
            
            //Assert          
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Test_Verifica_CentralitaExcepcionPorLLamadaProvincial()
        {
            //Arrange
            Provincial l1 = new Provincial("123", EFranja.Franja_1,34, "321");
            Provincial l2 = new Provincial("123", EFranja.Franja_2,56, "321");
            //Act
            Centralita central = new Centralita();
            _ = central + l1;
            _ = central + l2;

            //Assert          
        }

        [TestMethod]
        public void Test_Verifica_LLamadasIgualesPorTipo()
        {
            //Arrange
            Provincial p1 = new Provincial("123", EFranja.Franja_1, 34, "321");
            Provincial p2 = new Provincial("123", EFranja.Franja_2, 56, "321");
            Local l1 = new Local("123", 65, "321", 234);
            Local l2 = new Local("123", 25, "321", 100);
            //Act          

            //Assert
            Assert.AreNotEqual(l1, p1);
            Assert.AreEqual(l1, l2);
        }
    }
}
