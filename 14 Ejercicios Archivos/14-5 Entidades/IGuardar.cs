using System;

namespace _14_5_Entidades
{
    public interface IGuardar<T>
    {
        public string RutaDeArchivo
        {
            get; set;
        }
        public bool Guardar();
        public T Leer();
    }
}
