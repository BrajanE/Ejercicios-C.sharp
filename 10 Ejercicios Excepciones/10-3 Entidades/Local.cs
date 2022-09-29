using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_Entidades
{
    public class Local : LLamada
    {
        protected float costo;

        public Local(string nroOrigen, float duracion, string nroDestino, float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public Local(LLamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        private float CalcularCosto()
        {
            return costo * duracion;
        }
        public override float CostoLLamada
        {
            get { return CalcularCosto(); }
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("LLamada local");
            sb.AppendLine($"Costo: ${CostoLLamada}");
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Local);
        }
        public override string ToString()
        {
            return Mostrar();
        }
    }
}
