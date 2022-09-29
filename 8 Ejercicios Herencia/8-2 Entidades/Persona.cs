using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        protected long Dni { get => dni; set => dni = value; }
        protected string Nombre { get => nombre; set => nombre = value; }

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public Persona(long dni, string nombre):this (nombre)
        {
            this.Dni = dni;
        }
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.Append($"Dni: {Dni}");
            return sb.ToString();
        }

    }
}
