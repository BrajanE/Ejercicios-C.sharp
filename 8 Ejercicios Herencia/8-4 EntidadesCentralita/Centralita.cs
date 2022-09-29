using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_EntidadesCentralita
{
    public class Centralita
    {
        private List<LLamada> listaDeLLamada;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLLamada = new List<LLamada>();
        }

        public Centralita(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        public float GananciaPorLocar { get { return CalcularCosto(LLamada.ETipoLLamada.Local); } }
        public float GananciaPorProvincial { get { return CalcularCosto(LLamada.ETipoLLamada.Provincial); } }
        public float GananciaPorTotal { get { return CalcularCosto(LLamada.ETipoLLamada.Todas); } }
        public List<LLamada> LLamadas { get { return listaDeLLamada; } }
        public string RazonSocial { get { return razonSocial; } }
        

        private float CalcularCosto(LLamada.ETipoLLamada tipo)
        {
            float costoTotal = 0;
            if(tipo == LLamada.ETipoLLamada.Local || tipo == LLamada.ETipoLLamada.Todas)
            {
                foreach (LLamada ll in listaDeLLamada)
                {
                    if(ll is Local llamadaLocal)
                    {
                        costoTotal += llamadaLocal.CostoLLamada;
                    }
                }
            }
            if(tipo == LLamada.ETipoLLamada.Provincial || tipo == LLamada.ETipoLLamada.Todas)
            {
                foreach(LLamada ll in listaDeLLamada)
                {
                    if(ll is Provincial llamadaProvincial)
                    {
                        costoTotal += llamadaProvincial.CostoLLamada;
                    }
                }
            }
            return costoTotal;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"** Central Telefonica **");
            sb.AppendLine($"Razon social: {RazonSocial}");
            sb.AppendLine($"Ganancia por llamadas locales: ${GananciaPorLocar}");
            sb.AppendLine($"Ganancia por llamadas provinciales: $ {GananciaPorProvincial}");
            sb.AppendLine($"Ganancia total: ${GananciaPorTotal}\n");
            foreach (LLamada ll in listaDeLLamada)
            {
                if(ll is Local llamadaLocal)
                {
                    sb.AppendLine(llamadaLocal.Mostrar());
                }
                else if(ll is Provincial llamadaProvincial)
                {
                    sb.AppendLine(llamadaProvincial.Mostrar());
                }
            }          
            return sb.ToString();
        }
        public void OrdenarLLamadas()
        {
            listaDeLLamada.Sort(LLamada.OrdenarPorDuracion);
        }
    }
}
