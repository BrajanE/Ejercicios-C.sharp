using System;

namespace _10_3_Entidades
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CentralitaException()
        {
        }

        public CentralitaException(string mensaje, string clase, string metodo) : base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public string NombreClase { get => nombreClase; }
        public string NombreMetodo { get => nombreMetodo; }

    }
}
