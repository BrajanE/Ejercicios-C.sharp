using System;
using System.Text;

namespace _12_3_Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            CaballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza { get => caballosDeFuerza; set => caballosDeFuerza = value; }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine("Segmento Autos");
            sb.AppendLine($"Caballos de Fuerza: {CaballosDeFuerza}");
            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if ((a1.Escuderia == a2.Escuderia) && (a1.Numero == a2.Numero) && (a1.CaballosDeFuerza == a2.CaballosDeFuerza))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
