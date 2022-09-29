using System;
using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        protected string titular;
        protected decimal cantidad;

        public Cuenta(string titular, decimal cantidad) : this()
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public Cuenta()
        {
        }

        public string GetTitular()
        {
            return this.titular;
        }
        public decimal GetCuenta()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de cuenta:");
            sb.AppendLine($"\tRazon social - {GetTitular()}");
            sb.AppendLine($"\tDinero en cuenta - {GetCuenta()}");

            return sb.ToString();
        }

        public void Ingresar(decimal valorIngresado)
        {
            if(valorIngresado > 0)
            {
                this.cantidad += valorIngresado;
            }
        }

        public void Retirar(decimal valorIngresado)
        {
            this.cantidad -= valorIngresado;
        }
    }
}
