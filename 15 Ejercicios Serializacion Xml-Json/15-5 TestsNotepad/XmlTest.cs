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
    public class XmlTest
    {
        [TestMethod]
        public void ValidarExtension_True_CuandoLaExtensionSeaXml()
        {
            PuntoXml<string> archivoXml = new PuntoXml<string>();
            Assert.IsTrue(archivoXml.ValidarExtension("archivo.xml"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtension_Excepcion_CuandoLaExtensionNoSeaXml()
        {
            PuntoXml<string> archivoXml = new PuntoXml<string>();
            Assert.IsFalse(archivoXml.ValidarExtension("archivo.txt"));
        }
    }
}
