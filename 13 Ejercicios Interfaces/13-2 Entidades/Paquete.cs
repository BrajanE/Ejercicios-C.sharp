using System;
using System.Text;

namespace _13_2_Entidades
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad
        {
            get;
        }

        public decimal Impuestos 
        {
            get { return costoEnvio * (decimal)0.35; }
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos del paquete");
            sb.AppendLine($"Seguimiento: {codigoSeguimiento}");
            sb.AppendLine($"Costo de envio: {costoEnvio}");
            sb.AppendLine($"Destino: {destino}");
            sb.AppendLine($"Origen: {origen}");
            sb.AppendLine($"Peso en KG: {pesoKg}");
            if (TienePrioridad)
            {
                sb.AppendLine("Paquete con prioridad");
            }
            else sb.AppendLine("Paquete sin prioridad");

            return sb.ToString();
        }

        public virtual decimal AplicarImpuestos()
        {
            return costoEnvio + Impuestos;
        }
    }
}
