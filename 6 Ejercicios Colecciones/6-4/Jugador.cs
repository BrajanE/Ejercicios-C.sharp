using System.Text;

namespace _6_4
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles)
            : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
        public float GetPromedioGoles()
        {
            if (this.partidosJugados > 0)
            {
                return totalGoles / partidosJugados;
            }
            else
                return 0;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"**Datos Futbolisticos de {nombre}:");
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Goles totales: {totalGoles}");
            sb.AppendLine($"Promedio de goles: {promedioGoles}");
            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }



    }
}
