using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_5_Entidades
{
    public abstract class LLamada
    {
        public enum ETipoLLamada
        {
            Local, Provincial, Todas
        }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        protected string ruta;

        public LLamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public abstract float CostoLLamada { get; }
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
        protected virtual string Mostrar()
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
        public static bool operator ==(LLamada l1, LLamada l2)
        {
            if (Equals(l1, l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
            {
                return Equals(l1, l2);
            }
            return false;
        }
        public static bool operator !=(LLamada l1, LLamada l2)
        {
            return !(l1 == l2);
        }
    }
}
