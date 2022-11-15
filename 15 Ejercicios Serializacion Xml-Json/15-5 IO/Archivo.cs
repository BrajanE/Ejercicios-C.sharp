using System;
using System.IO;

namespace _15_5_IO
{
    public abstract class Archivo
    {
        protected abstract string Extension { get; }

        public bool ValidarExtension(string ruta)
        {
            if(Path.GetExtension(ruta) != Extension)
            {
                throw new ArchivoIncorrectoException($"El archivo no tiene la extension {Extension}");
            }
            return true;
        }
        public bool ValidarSiExisteElArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                return true;
            }
            throw new ArchivoIncorrectoException("El archivo no se encontro");
        }
    }
}
