using System;
using System.Collections.Generic;
using System.Text;

namespace _8_2_Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> listaJugadores;
        private string nombreEquipo;

        private Equipo()
        {
            listaJugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombreEquipo)
            : this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombreEquipo = nombreEquipo;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.listaJugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador jugador in e.listaJugadores)
                {
                    if (jugador == j)
                    {
                        return false;
                    }
                }
                e.listaJugadores.Add(j);
                return true;
            }
            return false;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Equipo: {nombreEquipo}");
            sb.AppendLine($"Cant. jugadores: {cantidadDeJugadores}");
          
            return sb.ToString();
        }
    }
}
