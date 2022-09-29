using System;
using System.Text;

namespace _8_2_Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;
        private DirectorTecnico(long dni, string nombre) : base(dni,nombre)
        {
        }
        public DirectorTecnico(long dni, string nombre,  DateTime fechaNacimiento) : this(dni, nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Director Tecnico");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Fecha de Nacimiento: {fechaNacimiento.ToString("MM/dd/yy")}");
            return sb.ToString();
        }
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return (dt1.Nombre == dt2.Nombre && dt1.fechaNacimiento == dt2.fechaNacimiento);
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}