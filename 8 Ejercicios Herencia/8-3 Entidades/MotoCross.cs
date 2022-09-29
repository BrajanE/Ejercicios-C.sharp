using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
        }
        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            Cilindrada = cilindrada;
        }

        public short Cilindrada { get => cilindrada; set => cilindrada = value; }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine("Segmento Motos");
            sb.AppendLine($"Cilindrada: {Cilindrada}");
            return sb.ToString();
        }
        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            if ((m1.Escuderia == m2.Escuderia) && (m1.Numero == m2.Numero) && (m1.Cilindrada == m2.Cilindrada))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}
