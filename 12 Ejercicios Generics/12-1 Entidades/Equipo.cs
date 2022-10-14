using System;
using System.Text;

namespace _12_1_Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

        protected Equipo(string nombre)
        {
            this.Nombre = nombre;
            this.FechaCreacion = DateTime.Now;
        }
        protected Equipo(string nombre, DateTime fechaCreacion) : this(nombre)
        {           
            this.FechaCreacion = fechaCreacion;
        }

        public static bool operator == (Equipo e1, Equipo e2)
        {
            if (e1 is not null && e2 is not null)
            {
                if (e1.Nombre == e2.Nombre && e1.FechaCreacion == e2.FechaCreacion)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator != (Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"[{Nombre}] fundado el [{FechaCreacion}]");
            return sb.ToString();
        }
    }
}
