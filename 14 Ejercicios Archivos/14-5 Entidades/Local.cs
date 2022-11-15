using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _14_5_Entidades
{
    public class Local : LLamada, IGuardar<Local>
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

        //INTERFACE
        public string RutaDeArchivo
        {
            get { return ruta; }
            set { ruta = value; }
        }
       
        public bool Guardar()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(RutaDeArchivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Local));
                    serializer.Serialize(sw, this);
                    return true;
                }
            }
            catch
            {
                throw new Exception("Error al guardar registro");
            }
        }

        public Local Leer()
        {
            try
            {
                if (File.Exists(RutaDeArchivo))
                {
                    using (StreamReader sr = new StreamReader(RutaDeArchivo))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Local));
                        return (Local)serializer.Deserialize(sr);
                    }
                }
            }
            catch(InvalidCastException ex)
            {
                throw new InvalidCastException($"Datos incorrectos\n{ex.Message}");
            }
            return null;
        }
    }
}
