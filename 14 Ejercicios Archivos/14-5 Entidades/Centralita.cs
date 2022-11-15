using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _14_5_Entidades
{
    public class Centralita : IGuardar<string>
    {
        private List<LLamada> listaDeLLamada;
        protected string razonSocial;
        private string ruta;
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
                try
                {
                    c.Guardar();
                }
                catch (CentralitaException ex)
                {
                    throw new CentralitaException("Falla al guardar archivo de llamadas", "Centralita", "Guardar");
                }
                finally
                {
                    c.AgregarLLamada(ll);

                }
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
        public string RutaDeArchivo
        {
            get { return ruta; }
            set { ruta = value; }
        }

        public bool Guardar()
        {
            RutaDeArchivo = Directory.GetCurrentDirectory() + "-LLamadas.txt";

            using (StreamWriter escritor = new StreamWriter(RutaDeArchivo, true))
            {
                escritor.WriteLine("LLamada realizada el dia " + DateTime.Now.ToString("F"));
            }

            return true;


        }

        public string Leer()
        {
            string archivoLeido = "";
           // if(!string.IsNullOrWhiteSpace(RutaDeArchivo) || !File.Exists(RutaDeArchivo))
            try
            {
                using (StreamReader lector = new StreamReader(RutaDeArchivo))
                {
                    archivoLeido = lector.ReadToEnd();
                }
            }  
            catch (Exception ex)
            {
                throw new CentralitaException("Error en carga de archivo", "Centralita","Leer");
            }
                
            return archivoLeido;
        }


    }
}
