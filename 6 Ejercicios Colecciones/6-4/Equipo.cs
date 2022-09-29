using System.Collections.Generic;

namespace _6_4
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
          
            
            //if (e.listaJugadores.Count < e.cantidadDeJugadores)
            //{
            //    for (int i = 0; i < e.listaJugadores.Count; i++)
            //    {
            //        if (e.listaJugadores[i] == j && e.listaJugadores[i] is not null)
            //        {

            //            return false;
            //        }
            //    }
            //    e.listaJugadores.Add(j);
            //    return true;
            //}
            //return false;
        }

    }
}
