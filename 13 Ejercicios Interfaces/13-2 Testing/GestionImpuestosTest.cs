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
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            //Arrange
            PaqueteFragil pp1 = new PaqueteFragil("123", 100, "B", "A", 5);
            PaqueteFragil pp2 = new PaqueteFragil("123", 200, "B", "A", 5);
            PaquetePesado pp3 = new PaquetePesado("123", (decimal)5575, "B", "A", 5);
            PaquetePesado pp4 = new PaquetePesado("123", (decimal)2000, "B", "A", 5);
            List<Paquete> listaP = new List<Paquete>();
            listaP.Add(pp1); listaP.Add(pp2); listaP.Add(pp3); listaP.Add(pp4);
            GestionImpuestos impuestos = new GestionImpuestos();
            impuestos.RegistrarImpuestos(listaP);
            decimal valorEsperado = (decimal)(5575*0.35 + 2000*0.35 + 100*0.35 + 200*0.35);

            //Act
            decimal valorObtenido = impuestos.CalcularTotalImpuestosAduana();

            //Assert
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            //Arrange
            PaqueteFragil pp1 = new PaqueteFragil("123", 100, "B", "A", 5);
            PaqueteFragil pp2 = new PaqueteFragil("123", 200, "B", "A", 5);
            PaquetePesado pp3 = new PaquetePesado("123", (decimal)5575, "B", "A", 5);
            PaquetePesado pp4 = new PaquetePesado("123", (decimal)2000, "B", "A", 5);
            List<Paquete> listaP = new List<Paquete>();
            listaP.Add(pp1); listaP.Add(pp2); listaP.Add(pp3); listaP.Add(pp4);
            GestionImpuestos impuestos = new GestionImpuestos();
            impuestos.RegistrarImpuestos(listaP);
            decimal valorEsperado = (decimal)(5575 * 0.25 + 2000 * 0.25);

            //Act
            decimal valorObtenido = impuestos.CalcularTotalImpuestosAfip();

            //Assert
            Assert.AreEqual(valorEsperado, valorObtenido);
        }
    }
}
