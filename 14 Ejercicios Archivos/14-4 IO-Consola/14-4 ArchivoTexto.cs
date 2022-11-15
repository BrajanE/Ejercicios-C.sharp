using System;
using System.IO;

namespace _14_4_IO_Consola
{
    public abstract class _14_4_ArchivoTexto
    {
        public static void Guardar(string mensaje, string ruta)
        {
            if (!string.IsNullOrWhiteSpace(ruta))
            {
                using (StreamWriter escritor = new StreamWriter(ruta))
                {
                    escritor.Write(mensaje);
                }
            }
        }
        public static string Leer(string ruta)
        {
            string archivoLeido;
            try
            {

                using (StreamReader lector = new StreamReader(ruta))
                {
                    archivoLeido = lector.ReadToEnd();
                }
                return archivoLeido;
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException();
            }
        }

    }
}
