using System;
using System.Text;

namespace _7_3_Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;       
        private int totalGoles;

        private Jugador()
        {
            partidosJugados = 0;            
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
        public int PartidosJugados
        {
            get { return partidosJugados; }
        }
        public int TotalGoles
        {
            get { return totalGoles; }
        }
        public float PromedioGoles
        {
            get 
            {
                if (PartidosJugados > 0)
                {
                    return TotalGoles / PartidosJugados;
                }
                else
                    return 0;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set { nombre = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
       
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"**Datos Futbolisticos de {Nombre}:");
            sb.AppendLine($"Partidos jugados: {PartidosJugados}");
            sb.AppendLine($"Goles totales: {TotalGoles}");
            sb.AppendLine($"Promedio de goles: {PromedioGoles}");
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
