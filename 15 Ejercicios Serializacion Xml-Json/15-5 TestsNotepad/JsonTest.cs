using Microsoft.VisualStudio.TestTools.UnitTesting;
using _15_5_IO;

namespace _15_5_TestsNotepad
{
    [TestClass]
    public class JsonTest
    {
        [TestMethod]
        public void ValidarExtension_True_CuandoLaExtensionSeaJson()
        {
            PuntoJson<string> archivoJson = new PuntoJson<string>();
            Assert.IsTrue(archivoJson.ValidarExtension("archivo.json"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtension_Excepcion_CuandoLaExtensionNoSeaJson()
        {
            PuntoJson<string> archivoJson = new PuntoJson<string>();
            Assert.IsFalse(archivoJson.ValidarExtension("archivo.txt"));
        }
    }
}
