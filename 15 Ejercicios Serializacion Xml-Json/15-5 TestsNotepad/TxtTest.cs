using _15_5_IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_5_TestsNotepad
{
    [TestClass]
    public class TxtTest
    {
        [TestMethod]
        public void ValidarExtension_True_CuandoLaExtensionSeaXml()
        {
            PuntoTxt archivoTxt = new PuntoTxt();
            Assert.IsTrue(archivoTxt.ValidarExtension("archivo.txt"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtension_Excepcion_CuandoLaExtensionNoSeaXml()
        {
            PuntoTxt archivoTxt = new PuntoTxt();
            Assert.IsFalse(archivoTxt.ValidarExtension("archivo.xml"));
        }
    }
}
