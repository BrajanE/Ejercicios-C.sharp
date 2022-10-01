using Microsoft.VisualStudio.TestTools.UnitTesting;
using _11_1_Entidades;
using System;

namespace Testeos
{
    [TestClass]
    public class CalculadoraTest
    {
        //PARTE 1

        [TestMethod]
        public void Add_LosStringVaciosSeTomanComoCeroYAdmiteHastaDosNumeros()
        {
            //Arrange          
            string n1 = " , 2,2,1";

            CalculadoraDeStrings calculadora = new CalculadoraDeStrings();
            int resultadoEsperado = 2;
            //Act
            int resultadoObtenido = calculadora.AddV1(n1);
            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        //PARTE 2

        [TestMethod]
        public void Add_DeberiaAdmitirDesconocidaCantidadDeNumeros()
        {
            //Arrange          
            string n1 = " , 2,2,1,6";

            CalculadoraDeStrings calculadora = new CalculadoraDeStrings();
            int resultadoEsperado = 11;
            //Act
            int resultadoObtenido = calculadora.AddV2(n1);
            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        //PARTE 3

        [TestMethod]
        public void Add_DeberiaAdmitirSeparacionPorComaYSaltoDeLinea()
        {
            //Arrange          
            string n1 = " , 2,\n2,1\n,6,\n";

            CalculadoraDeStrings calculadora = new CalculadoraDeStrings();
            int resultadoEsperado = 11;
            //Act
            int resultadoObtenido = calculadora.AddV3(n1);
            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        //PARTE 4

        [TestMethod]
        public void Add_DeberiaAdmitirDiferentesDelimitadores()
        {
            //Arrange          
            string n1 = "//; \n1; 2";

            CalculadoraDeStrings calculadora = new CalculadoraDeStrings();
            int resultadoEsperado = 3;
            //Act
            int resultadoObtenido = calculadora.AddV4(n1);
            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        //PARTE 5

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Add_DeberiaControlarExcepcionNumeroNegativo()
        {
            //Arrange          
            string n1 = "//; \n1; -22";

            CalculadoraDeStrings calculadora = new CalculadoraDeStrings();
            
            //Act
            int resultadoObtenido = calculadora.AddV5(n1);
            //Assert           
        }

    }
}
