using System.Text;

namespace _8_4_EntidadesCentralita
{

    public class LLamada
    {
        public enum ETipoLLamada
        {
            Local, Provincial, Todas
        }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public LLamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get { return duracion; }
        }
        public string NroDestino
        {
            get { return nroDestino; }
        }
        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();          
            sb.AppendLine($"Informacion de llamada:");
            sb.AppendLine($"Nro Origen: {NroOrigen}");
            sb.AppendLine($"Nro Destino: {NroDestino}");
            sb.AppendLine($"Duracion: {Duracion}");
            return sb.ToString();
        }
        public static int OrdenarPorDuracion(LLamada l1, LLamada l2)
        {
            return (int)l1.Duracion - (int)l2.Duracion;
        }
    }
}
