﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_Entidades
{
    public class Centralita : IGuardar <string>
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
            if (tipo == LLamada.ETipoLLamada.Local || tipo == LLamada.ETipoLLamada.Todas)
            {
                foreach (LLamada ll in listaDeLLamada)
                {
                    if (ll is Local llamadaLocal)
                    {
                        costoTotal += llamadaLocal.CostoLLamada;
                    }
                }
            }
            if (tipo == LLamada.ETipoLLamada.Provincial || tipo == LLamada.ETipoLLamada.Todas)
            {
                foreach (LLamada ll in listaDeLLamada)
                {
                    if (ll is Provincial llamadaProvincial)
                    {
                        costoTotal += llamadaProvincial.CostoLLamada;
                    }
                }
            }
            return costoTotal;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"** Central Telefonica **");
            sb.AppendLine($"Razon social: {RazonSocial}");
            sb.AppendLine($"Ganancia por llamadas locales: ${GananciaPorLocar}");
            sb.AppendLine($"Ganancia por llamadas provinciales: $ {GananciaPorProvincial}");
            sb.AppendLine($"Ganancia total: ${GananciaPorTotal}\n");
            foreach (LLamada ll in listaDeLLamada)
            {
                if (ll is Local llamadaLocal)
                {
                    sb.AppendLine(llamadaLocal.ToString());
                }
                else if (ll is Provincial llamadaProvincial)
                {
                    sb.AppendLine(llamadaProvincial.ToString());
                }
            }
            return sb.ToString();
        }
        public void OrdenarLLamadas()
        {
            listaDeLLamada.Sort(LLamada.OrdenarPorDuracion);
        }
        private void AgregarLLamada(LLamada nuevaLLamada)
        {
            listaDeLLamada.Add(nuevaLLamada);
        }
        public static bool operator ==(Centralita c, LLamada ll)
        {
            foreach (LLamada llamada in c.listaDeLLamada)
            {
                if (llamada == ll)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c, LLamada ll)
        {
            return !(c == ll);
        }
        public static Centralita operator +(Centralita c, LLamada ll)
        {

            if (c != ll)
            {
                c.AgregarLLamada(ll);
                return c;
            }
            else
            {
                throw new CentralitaException($"Error, la siguiente llamada ya estan registrada:\n\n{ll}", "Clase: Centralita", "Metodo: Operacion + (agregar llamda a historial)");
            }


        }
        public override string ToString()
        {
            return Mostrar();
        }

        // INTERFACE
        public string RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Guardar()
        {
            if (this.LLamadas is not null && !String.IsNullOrEmpty(this.RazonSocial))
            {
                return true;
            }
            return false;
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }
    }
}
