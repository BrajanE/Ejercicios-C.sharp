using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace _14_5_Entidades
{
    public enum EFranja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }
    public class Provincial : LLamada, IGuardar<Provincial>
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
                    XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
                    serializer.Serialize(sw, this);
                    return true;
                }
            }
            catch
            {
                throw new Exception("Error al guardar registro");
            }
        }

        public Provincial Leer()
        {
            try
            {
                if (File.Exists(RutaDeArchivo))
                {
                    using (StreamReader sr = new StreamReader(RutaDeArchivo))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
                        return (Provincial)serializer.Deserialize(sr);
                    }
                }
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidCastException($"Datos incorrectos\n{ex.Message}");
            }
            return null;
        }
    }
}
