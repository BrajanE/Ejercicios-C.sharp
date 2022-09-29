using System.Text;

namespace _8_2_Entidades
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(long dni, string nombre) : base(dni, nombre)
        {
        }
        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles)
            : this(dni, nombre)
        {
            PartidosJugados = partidosJugados;
            TotalGoles = totalGoles;
        }

        public int PartidosJugados
        {
            get { return partidosJugados; }
            set
            {
                if (value > 0)
                {
                    partidosJugados = value;
                }
                else partidosJugados = 0;
            }
        }
        public int TotalGoles
        {
            get { return totalGoles; }
            set
            {
                if (value > 0)
                {
                    totalGoles = value;
                }
                else totalGoles = 0;
            }
        }
        public float PromedioGoles
        {
            get
            {
                if (PartidosJugados > 0)
                {
                    return TotalGoles / (float)PartidosJugados;
                }
                else
                    return 0;
            }
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Jugador");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Partidos jugados: {PartidosJugados}");          
            sb.AppendLine($"Total goles: {TotalGoles}");
            sb.AppendLine($"Promedio goles: {PromedioGoles:N2}");
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
