using System;
using System.Collections.Generic;
using System.Text;

namespace _12_1_Entidades
{
    public class TorneoGenerico<T>
        where T : Equipo
    {
        public List<T> listaEquipos;
        public string nombreTorneo;

        public TorneoGenerico(string nombreTorneo)
        {
            this.nombreTorneo = nombreTorneo;
            listaEquipos = new List<T>();
        }

        public static bool operator ==(TorneoGenerico<T> torneo, T nEquipo)
        {
            if (torneo is not null && nEquipo is not null)
            {
                foreach (T equipo in torneo.listaEquipos)
                {
                    if (equipo == nEquipo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(TorneoGenerico<T> torneo, T nEquipo)
        {
            return !(torneo == nEquipo);
        }
        public static bool operator +(TorneoGenerico<T> torneo, T nEquipo)
        {
            if (torneo is not null && nEquipo is not null)
            {
                if (torneo != nEquipo)
                {
                    torneo.listaEquipos.Add(nEquipo);
                    return true;
                }
            }

            return false;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo: {nombreTorneo}");
            if (listaEquipos is not null)
            {
                foreach (T equipo in listaEquipos)
                {
                    sb.Append(equipo.Ficha());
                }
            }
            else sb.AppendLine("No se registraron equipos");
            return sb.ToString();
        }
        private string CalcularPartido(T primerObj, T segundoObj)
        {
            Random rdn = new Random();
            return $"[{primerObj.Nombre}] [{rdn.Next(0, 5)}] - [{segundoObj.Nombre}] [{rdn.Next(0, 5)}]";
        }
        public string JugarPartido
        {
            get
            {
                Random rdn = new Random();
                T equipo1;
                T equipo2;  
                do
                {
                    equipo1 = listaEquipos[rdn.Next(0, listaEquipos.Count)];
                    equipo2 = listaEquipos[rdn.Next(0, listaEquipos.Count)];
                } while (equipo1 == equipo2);

                return "Puntaje de partido:\n" + CalcularPartido(equipo1, equipo2);
            }
        }
    }
}
