using System;
using System.Text;

namespace _3_2_Entidades
{
    public class Personas
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Personas(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public void SetNombre( string nuevoNombre)
        {
            if (nombre != nuevoNombre || nuevoNombre is not null)
            {
                this.nombre = nuevoNombre;
            }
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetFechaDeNacimiento(DateTime nuevaFecha)
        {
            if(!this.fechaDeNacimiento.Equals(nuevaFecha))
            {
                this.fechaDeNacimiento = nuevaFecha;
            }
        }
        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }
        public void SetDni(int nuevoDni)
        {
            this.dni = nuevoDni;
        }
        public int GetDni()
        {
            return this.dni;
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - GetFechaDeNacimiento().Year;
            return edad;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del sujeto:");
            sb.AppendLine($"*Nombre: {GetNombre()}");
            sb.AppendLine($"*Fecha de Nacimiento: {GetFechaDeNacimiento()}");
            sb.AppendLine($"*Edad actual: {CalcularEdad()}");
            sb.AppendLine($"*Dni: {GetDni()}");
            sb.AppendLine($"{EsMayorDeEdad()}");
            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            if (CalcularEdad() > 17)
            {
                return "Es mayor de edad";
            } else return "Es menor de edad";
        }
    }
}
