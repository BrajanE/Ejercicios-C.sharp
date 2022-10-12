using Microsoft.VisualStudio.TestTools.UnitTesting;
using _11_3_Entidades;
using System;

namespace _11_3_LanzarTesting
{
    [TestClass]
    public class Testeos
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ExcepcionAlDividirPorCeroMetodo()
        {
            MiClase.DivisionPorCero(50, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void Test_ExcepcionAlDividirPorCeroClase()
        {
            MiClase prueba = new MiClase();    
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void Test_ExcepcionAlDividirPorCeroClaseParametrizada()
        {
            MiClase prueba = new MiClase(60);
        }   
    }
}
