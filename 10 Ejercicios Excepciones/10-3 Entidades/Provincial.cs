using System.Linq;
using System.Text;

namespace _10_3_Entidades
{
    public enum EFranja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }
    public class Provincial : LLamada
    {

        protected EFranja franjaHoraria;

        public Provincial(string nroOrigen, EFranja miFranja, float duracion, string nroDestino) : base(duracion, nroDestino, nroOrigen)
        {
            franjaHoraria = miFranja;
        }
        public Provincial(EFranja franja, LLamada llamada) : this(llamada.NroOrigen, franja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public override float CostoLLamada
        {
            get { return CalcularCosto(); }
        }
        private float CalcularCosto()
        {
            float costo = 0;
            switch (franjaHoraria)
            {
                case EFranja.Franja_1:
                    costo = (float)(Duracion * 0.99);
                    break;
                case EFranja.Franja_2:
                    costo = (float)(Duracion * 1.25);
                    break;
                case EFranja.Franja_3:
                    costo = (float)(Duracion * 0.66);
                    break;
            }
            return costo;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("LLamada provincial");
            sb.AppendLine($"Costo: ${CostoLLamada}");
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
        }
        public override string ToString()
        {
            return Mostrar();
        }
    }

}
