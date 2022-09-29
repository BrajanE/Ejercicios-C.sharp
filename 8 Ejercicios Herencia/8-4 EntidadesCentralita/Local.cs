using System.Text;

namespace _8_4_EntidadesCentralita
{
    public class Local : LLamada
    {
        protected float costo;

        public Local(string nroOrigen, float duracion, string nroDestino, float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public Local(LLamada llamada,float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        private float CalcularCosto()
        {
            return costo * duracion;
        }
        public float CostoLLamada
        {
            get { return CalcularCosto(); }
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("LLamada local");
            sb.AppendLine($"Costo: ${CostoLLamada}");
            return sb.ToString();
        }


    }
}
