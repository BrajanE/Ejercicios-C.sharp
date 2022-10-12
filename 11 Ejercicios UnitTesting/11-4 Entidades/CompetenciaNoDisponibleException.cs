using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_Entidades
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;
        public CompetenciaNoDisponibleException()
        {
        }
        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo) : base(mensaje)
        {
            this.nombreMetodo = nombreMetodo;
            this.nombreClase = nombreClase;
        }
        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreMetodo = nombreMetodo;
            this.nombreClase = nombreClase;
        }

        public string NombreClase { get => nombreClase; }
        public string NombreMetodo { get => nombreMetodo; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepcion en el metodo: {NombreMetodo}, de la clase: {NombreClase}:");
            sb.AppendLine(Message);
            if (InnerException is not null)
            {
                sb.Append($"{InnerException}\t");
            }
            return sb.ToString();
        }
    }
}
